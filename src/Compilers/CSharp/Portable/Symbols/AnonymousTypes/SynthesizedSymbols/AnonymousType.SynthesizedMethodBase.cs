// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private abstract class SynthesizedMethodBase : SynthesizedInstanceMethodSymbol
        {
            private readonly NamedTypeSymbol _containingType;

            private readonly string _name;

            public SynthesizedMethodBase(NamedTypeSymbol containingType, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10428, 884, 1069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 808, 823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 862, 867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 990, 1023);

                    _containingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1041, 1054);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10428, 884, 1069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 884, 1069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 884, 1069);
                }
            }

            internal sealed override bool GenerateDebugInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1165, 1186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1171, 1184);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1165, 1186);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1085, 1201);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1085, 1201);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override int Arity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1282, 1299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1288, 1297);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1282, 1299);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1217, 1314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1217, 1314);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1409, 1440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1415, 1438);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1409, 1440);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1330, 1455);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1330, 1455);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1550, 1636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1594, 1617);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1550, 1636);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1471, 1651);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1471, 1651);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1750, 1796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1756, 1794);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1750, 1796);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1667, 1811);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1667, 1811);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override Accessibility DeclaredAccessibility
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 1918, 1954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 1924, 1952);

                        return Accessibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 1918, 1954);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1827, 1969);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1827, 1969);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsStatic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2054, 2075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2060, 2073);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2054, 2075);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 1985, 2090);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 1985, 2090);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsVirtual
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2176, 2197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2182, 2195);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2176, 2197);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2106, 2212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2106, 2212);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsAsync
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2296, 2317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2302, 2315);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2296, 2317);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2228, 2332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2228, 2332);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override System.Reflection.MethodImplAttributes ImplementationAttributes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2469, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2475, 2530);

                        return default(System.Reflection.MethodImplAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2469, 2532);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2348, 2547);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2348, 2547);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override Cci.CallingConvention CallingConvention
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2660, 2705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2666, 2703);

                        return Cci.CallingConvention.HasThis;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2660, 2705);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2563, 2720);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2563, 2720);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsExtensionMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2814, 2835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2820, 2833);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2814, 2835);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2736, 2850);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2736, 2850);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool HidesBaseMethodsByName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 2949, 2970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 2955, 2968);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 2949, 2970);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 2866, 2985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 2866, 2985);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsVararg
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3070, 3091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3076, 3089);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3070, 3091);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3001, 3106);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3001, 3106);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3203, 3234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3206, 3234);
                        return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3203, 3234);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3203, 3234);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3203, 3234);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3331, 3364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3334, 3364);
                        return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3331, 3364);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3331, 3364);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3331, 3364);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3501, 3558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3507, 3556);

                        return ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3501, 3558);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3381, 3573);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3381, 3573);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3695, 3752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3701, 3750);

                        return ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3695, 3752);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3589, 3767);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3589, 3767);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsExplicitInterfaceImplementation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 3879, 3900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 3885, 3898);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 3879, 3900);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3783, 3915);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3783, 3915);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4048, 4098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4054, 4096);

                        return ImmutableArray<MethodSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4048, 4098);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 3931, 4113);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 3931, 4113);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsDeclaredReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4234, 4242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4237, 4242);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4234, 4242);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4234, 4242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4234, 4242);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsInitOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4300, 4308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4303, 4308);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4300, 4308);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4300, 4308);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4300, 4308);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4430, 4482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4436, 4480);

                        return ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4430, 4482);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4325, 4497);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4325, 4497);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4585, 4605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4591, 4603);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4585, 4605);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4513, 4620);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4513, 4620);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsAbstract
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4707, 4728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4713, 4726);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4707, 4728);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4636, 4743);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4636, 4743);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsSealed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4828, 4849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4834, 4847);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4828, 4849);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4759, 4864);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4759, 4864);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsExtern
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 4949, 4970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 4955, 4968);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 4949, 4970);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 4880, 4985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 4880, 4985);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 5068, 5089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5074, 5087);

                        return _name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 5068, 5089);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 5001, 5104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 5001, 5104);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 5120, 5279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5251, 5264);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 5120, 5279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 5120, 5279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 5120, 5279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 5295, 5729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5461, 5522);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10428, 5461, 5521);
                    base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10428, 5461, 5521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5542, 5714);

                    f_10428_5542_5713(ref attributes, f_10428_5582_5712(f_10428_5582_5601(f_10428_5582_5589()), WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 5295, 5729);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    f_10428_5582_5589()
                    {
                        var return_v = Manager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10428, 5582, 5589);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10428_5582_5601(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10428, 5582, 5601);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10428_5582_5712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor)
                    {
                        var return_v = this_param.TrySynthesizeAttribute(constructor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10428, 5582, 5712);
                        return return_v;
                    }


                    int
                    f_10428_5542_5713(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10428, 5542, 5713);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 5295, 5729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 5295, 5729);
                }
            }

            protected AnonymousTypeManager Manager
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 5816, 6095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5860, 5946);

                        AnonymousTypeTemplateSymbol
                        template = _containingType as AnonymousTypeTemplateSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 5968, 6076);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10428, 5975, 6001) || ((((object)template != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10428, 6004, 6020)) || DynAbs.Tracing.TraceSender.Conditional_F3(10428, 6023, 6075))) ? template.Manager : ((AnonymousTypePublicSymbol)_containingType).Manager;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 5816, 6095);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 5745, 6110);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 5745, 6110);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6211, 6232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 6217, 6230);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6211, 6232);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6126, 6247);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6126, 6247);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override DllImportData GetDllImportData()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6263, 6378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 6351, 6363);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6263, 6378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6263, 6378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6263, 6378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6518, 6538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 6524, 6536);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6518, 6538);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6394, 6553);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6394, 6553);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool HasDeclarativeSecurity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6654, 6675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 6660, 6673);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6654, 6675);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6569, 6690);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6569, 6690);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6706, 6875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 6823, 6860);

                    throw f_10428_6829_6859();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6706, 6875);

                    System.Exception
                    f_10428_6829_6859()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10428, 6829, 6859);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6706, 6875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6706, 6875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 6891, 7053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7002, 7038);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 6891, 7053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 6891, 7053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 6891, 7053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool SynthesizesLoweredBoundBody
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 7152, 7227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7196, 7208);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 7152, 7227);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 7069, 7242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 7069, 7242);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected SyntheticBoundNodeFactory CreateBoundNodeFactory(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 7258, 7604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7415, 7519);

                    var
                    F = f_10428_7423_7518(this, f_10428_7459_7486(this), compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7537, 7562);

                    F.CurrentFunction = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7580, 7589);

                    return F;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 7258, 7604);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10428_7459_7486(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedMethodBase
                    symbol)
                    {
                        var return_v = symbol.GetNonNullSyntaxNode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10428, 7459, 7486);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10428_7423_7518(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedMethodBase
                    topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10428, 7423, 7518);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 7258, 7604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 7258, 7604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10428, 7620, 7801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10428, 7749, 7786);

                    throw f_10428_7755_7785();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10428, 7620, 7801);

                    System.Exception
                    f_10428_7755_7785()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10428, 7755, 7785);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10428, 7620, 7801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 7620, 7801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SynthesizedMethodBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10428, 672, 7812);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10428, 672, 7812);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10428, 672, 7812);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10428, 672, 7812);
        }
    }
}
