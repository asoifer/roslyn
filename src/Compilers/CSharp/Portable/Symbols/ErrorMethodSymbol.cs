// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ErrorMethodSymbol : MethodSymbol
    {
        public static readonly ErrorMethodSymbol UnknownMethod;

        private readonly TypeSymbol _containingType;

        private readonly TypeSymbol _returnType;

        private readonly string _name;

        public ErrorMethodSymbol(TypeSymbol containingType, TypeSymbol returnType, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10104, 776, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 658, 673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 712, 723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 758, 763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 888, 921);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 935, 960);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 974, 987);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10104, 776, 998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 776, 998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 776, 998);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1062, 1083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1068, 1081);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1062, 1083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1010, 1094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1010, 1094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1175, 1196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1181, 1194);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1175, 1196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1106, 1207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1106, 1207);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1325, 1388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1331, 1386);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1325, 1388);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1219, 1399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1219, 1399);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1465, 1486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1471, 1484);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1465, 1486);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1411, 1497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1411, 1497);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1563, 1584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1569, 1582);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1563, 1584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1509, 1595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1509, 1595);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1663, 1684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1669, 1682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1663, 1684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1607, 1695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1607, 1695);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1763, 1784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1769, 1782);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1763, 1784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1707, 1795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1707, 1795);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1862, 1883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1868, 1881);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1862, 1883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1807, 1894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1807, 1894);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 1960, 1981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 1966, 1979);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 1960, 1981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 1906, 1992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 1906, 1992);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2057, 2078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2063, 2076);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2057, 2078);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2004, 2089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2004, 2089);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2194, 2214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2200, 2212);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2194, 2214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2101, 2225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2101, 2225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2353, 2360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2356, 2360);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2353, 2360);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2353, 2360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2353, 2360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2449, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2455, 2483);

                    return Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2449, 2485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2373, 2496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2373, 2496);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2583, 2629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2589, 2627);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2583, 2629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2508, 2640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2508, 2640);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2750, 2846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2786, 2831);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2750, 2846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2652, 2857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2652, 2857);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 2933, 2964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 2939, 2962);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 2933, 2964);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2869, 2975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2869, 2975);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3079, 3134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3085, 3132);

                    return Microsoft.Cci.CallingConvention.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3079, 3134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 2987, 3145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 2987, 3145);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3221, 3241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3227, 3239);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3221, 3241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3157, 3252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3157, 3252);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3354, 3406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3360, 3404);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3354, 3406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3264, 3417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3264, 3417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3510, 3531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3516, 3529);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3510, 3531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3429, 3542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3429, 3542);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3656, 3706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3662, 3704);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3656, 3706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3554, 3717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3554, 3717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3771, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3774, 3779);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3771, 3779);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3771, 3779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3771, 3779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3826, 3834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3829, 3834);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3826, 3834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3826, 3834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3826, 3834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 3908, 3925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 3914, 3923);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 3908, 3925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3847, 3936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3847, 3936);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4031, 4084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4037, 4082);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4031, 4084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 3948, 4095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 3948, 4095);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4198, 4255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4204, 4253);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4198, 4255);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4107, 4266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4107, 4266);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4383, 4440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4389, 4438);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4383, 4440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4278, 4451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4278, 4451);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4519, 4547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4525, 4545);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4519, 4547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4463, 4558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4463, 4558);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4656, 4711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4662, 4709);

                    return TypeWithAnnotations.Create(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4656, 4711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4570, 4722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4570, 4722);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4791, 4835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4797, 4833);

                    return f_10104_4804_4832(f_10104_4804_4819(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4791, 4835);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10104_4804_4819(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10104, 4804, 4819);
                        return return_v;
                    }


                    bool
                    f_10104_4804_4832(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10104, 4804, 4832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4734, 4846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4734, 4846);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 4932, 4963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 4935, 4963);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 4932, 4963);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 4932, 4963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 4932, 4963);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5049, 5082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5052, 5082);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5049, 5082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5049, 5082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5049, 5082);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5159, 5190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5162, 5190);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5159, 5190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5159, 5190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5159, 5190);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5257, 5278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5263, 5276);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5257, 5278);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5203, 5289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5203, 5289);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5369, 5390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5375, 5388);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5369, 5390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5301, 5401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5301, 5401);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5476, 5497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5482, 5495);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5476, 5497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5413, 5508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5413, 5508);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5570, 5587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5576, 5585);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5570, 5587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5520, 5598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5520, 5598);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 5672, 6063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5708, 6048);

                    switch (_name)
                    {

                        case WellKnownMemberNames.InstanceConstructorName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10104, 5708, 6048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 5839, 5869);

                            return MethodKind.Constructor;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10104, 5708, 6048);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10104, 5708, 6048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6002, 6029);

                            return MethodKind.Ordinary;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10104, 5708, 6048);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 5672, 6063);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 5610, 6074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 5610, 6074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6086, 6233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6209, 6222);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6086, 6233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6086, 6233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6086, 6233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6245, 6392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6368, 6381);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6245, 6392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6245, 6392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6245, 6392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6467, 6531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6503, 6516);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6467, 6531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6404, 6542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6404, 6542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6631, 6652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6637, 6650);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6631, 6652);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6554, 6663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6554, 6663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6675, 6778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6755, 6767);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6675, 6778);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6675, 6778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6675, 6778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 6851, 6896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 6857, 6894);

                    throw f_10104_6863_6893();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 6851, 6896);

                    System.Exception
                    f_10104_6863_6893()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10104, 6863, 6893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6790, 6907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6790, 6907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7035, 7055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7041, 7053);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7035, 7055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 6919, 7066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 6919, 7066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7078, 7228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7181, 7217);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7078, 7228);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7078, 7228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7078, 7228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7317, 7338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7323, 7336);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7317, 7338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7240, 7349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7240, 7349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7361, 7518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7470, 7507);

                throw f_10104_7476_7506();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7361, 7518);

                System.Exception
                f_10104_7476_7506()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10104, 7476, 7506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7361, 7518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7361, 7518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7530, 7692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7644, 7681);

                throw f_10104_7650_7680();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7530, 7692);

                System.Exception
                f_10104_7650_7680()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10104, 7650, 7680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7530, 7692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7530, 7692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7769, 7790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7775, 7788);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7769, 7790);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7704, 7801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7704, 7801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10104, 7871, 7879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 7874, 7879);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10104, 7871, 7879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10104, 7871, 7879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 7871, 7879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ErrorMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10104, 384, 7887);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10104, 496, 617);
            UnknownMethod = f_10104_512_617(ErrorTypeSymbol.UnknownResultType, ErrorTypeSymbol.UnknownResultType, string.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10104, 384, 7887);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10104, 384, 7887);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10104, 384, 7887);

        static Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
        f_10104_512_617(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        returnType, string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10104, 512, 617);
            return return_v;
        }

    }
}
