// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.Cci;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedEmbeddedAttributeSymbolBase : NamedTypeSymbol
    {
        private readonly string _name;

        private readonly NamedTypeSymbol _baseType;

        private readonly NamespaceSymbol _namespace;

        private readonly ModuleSymbol _module;

        public SynthesizedEmbeddedAttributeSymbolBase(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10668, 1297, 1879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1124, 1129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1173, 1182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1226, 1236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1277, 1284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1527, 1556);

                f_10668_1527_1555(name is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1570, 1614);

                f_10668_1570_1613(containingNamespace is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1628, 1669);

                f_10668_1628_1668(containingModule is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1683, 1716);

                f_10668_1683_1715(baseType is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1732, 1745);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1759, 1792);

                _namespace = containingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1806, 1833);

                _module = containingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 1847, 1868);

                _baseType = baseType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10668, 1297, 1879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 1297, 1879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 1297, 1879);
            }
        }

        public new abstract ImmutableArray<MethodSymbol> Constructors { get; }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 1999, 2003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2002, 2003);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 1999, 2003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 1999, 2003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 1999, 2003);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2083, 2127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2086, 2127);
                    return ImmutableArray<TypeParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2083, 2127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2083, 2127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2083, 2127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2182, 2189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2185, 2189);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2182, 2189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2182, 2189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2182, 2189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2295, 2317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2298, 2317);
                return ManagedKind.Managed; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2295, 2317);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2295, 2317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2295, 2317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2378, 2385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2381, 2385);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2378, 2385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2378, 2385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2378, 2385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2448, 2456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2451, 2456);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2448, 2456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2448, 2456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2448, 2456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2497, 2505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2500, 2505);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2497, 2505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2497, 2505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2497, 2505);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2566, 2601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2569, 2601);
                    return f_10668_2569_2581().Select(m => m.Name); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2566, 2601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2566, 2601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2566, 2601);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2666, 2691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2669, 2691);
                    return Accessibility.Internal; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2666, 2691);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2666, 2691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2666, 2691);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2738, 2755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2741, 2755);
                    return TypeKind.Class; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2738, 2755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2738, 2755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2738, 2755);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2808, 2821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2811, 2821);
                    return _namespace; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2808, 2821);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2808, 2821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2808, 2821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2882, 2892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2885, 2892);
                    return _module; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2882, 2892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2882, 2892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2882, 2892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 2955, 2984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 2958, 2984);
                    return f_10668_2958_2984(_module); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 2955, 2984);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 2955, 2984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 2955, 2984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamespaceSymbol ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3049, 3062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3052, 3062);
                    return _namespace; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3049, 3062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3049, 3062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3049, 3062);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3126, 3159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3129, 3159);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3126, 3159);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3126, 3159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3126, 3159);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3246, 3286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3249, 3286);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3246, 3286);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3246, 3286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3246, 3286);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3329, 3337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3332, 3337);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3329, 3337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3329, 3337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3329, 3337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3385, 3393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3388, 3393);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3385, 3393);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3385, 3393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3385, 3393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3438, 3446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3441, 3446);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3438, 3446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3438, 3446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3438, 3446);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3491, 3499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3494, 3499);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3491, 3499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3491, 3499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3491, 3499);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3542, 3549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3545, 3549);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3542, 3549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3542, 3549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3542, 3549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3665, 3709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3668, 3709);
                    return ImmutableArray<TypeWithAnnotations>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3665, 3709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3665, 3709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3665, 3709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3756, 3764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3759, 3764);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3756, 3764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3756, 3764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3756, 3764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3833, 3840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3836, 3840);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3833, 3840);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3833, 3840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3833, 3840);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3891, 3899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3894, 3899);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3891, 3899);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3891, 3899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3891, 3899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 3947, 3955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 3950, 3955);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 3947, 3955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 3947, 3955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 3947, 3955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4014, 4022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4017, 4022);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4014, 4022);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4014, 4022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4014, 4022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4080, 4088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4083, 4088);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4080, 4088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4080, 4088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4080, 4088);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4137, 4145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4140, 4145);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4137, 4145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4137, 4145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4137, 4145);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4202, 4237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4205, 4237);
                    return f_10668_4205_4237(f_10668_4205_4221()); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4202, 4237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4202, 4237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4202, 4237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4286, 4296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4289, 4296);
                    return default; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4286, 4296);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4286, 4296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4286, 4296);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4354, 4382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4357, 4382);
                    return f_10668_4357_4382(); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4354, 4382);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4354, 4382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4354, 4382);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4441, 4449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4444, 4449);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4441, 4449);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4441, 4449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4441, 4449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4497, 4505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4500, 4505);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4497, 4505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4497, 4505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4497, 4505);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4581, 4593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4584, 4593);
                    return _baseType; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4581, 4593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4581, 4593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4581, 4593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4668, 4675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4671, 4675);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4668, 4675);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4668, 4675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4668, 4675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4765, 4804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4768, 4804);
                throw f_10668_4774_4804(); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4765, 4804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4765, 4804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4765, 4804);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10668_4774_4804()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 4774, 4804);
                return return_v;
            }

        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4869, 4904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4872, 4904);
                return f_10668_4872_4884().CastArray<Symbol>(); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4869, 4904);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4869, 4904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4869, 4904);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10668_4872_4884()
            {
                var return_v = Constructors;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 4872, 4884);
                return return_v;
            }

        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 4980, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 4983, 5101);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10668, 4983, 5035) || ((name == WellKnownMemberNames.InstanceConstructorName && DynAbs.Tracing.TraceSender.Conditional_F2(10668, 5038, 5070)) || DynAbs.Tracing.TraceSender.Conditional_F3(10668, 5073, 5101))) ? f_10668_5038_5050().CastArray<Symbol>() : ImmutableArray<Symbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 4980, 5101);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 4980, 5101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 4980, 5101);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10668_5038_5050()
            {
                var return_v = Constructors;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 5038, 5050);
                return return_v;
            }

        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5179, 5219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5182, 5219);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5179, 5219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5179, 5219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5179, 5219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5308, 5348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5311, 5348);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5308, 5348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5308, 5348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5308, 5348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5448, 5488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5451, 5488);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5448, 5488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5448, 5488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5448, 5488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5573, 5604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5576, 5604);
                return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5573, 5604);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5573, 5604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5573, 5604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5678, 5707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5681, 5707);
                return AttributeUsageInfo.Default; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5678, 5707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5678, 5707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5678, 5707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5815, 5827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5818, 5827);
                return _baseType; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5815, 5827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5815, 5827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5815, 5827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 5953, 5993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 5956, 5993);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 5953, 5993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 5953, 5993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 5953, 5993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6082, 6097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6085, 6097);
                return f_10668_6085_6097(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6082, 6097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6082, 6097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6082, 6097);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10668_6085_6097(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbolBase
            this_param)
            {
                var return_v = this_param.GetMembers();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 6085, 6097);
                return return_v;
            }

        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6197, 6216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6200, 6216);
                return f_10668_6200_6216(this, name); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6197, 6216);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6197, 6216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6197, 6216);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10668_6200_6216(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbolBase
            this_param, string
            name)
            {
                var return_v = this_param.GetMembers(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 6200, 6216);
                return return_v;
            }

        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6290, 6346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6293, 6346);
                return f_10668_6293_6346(); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6290, 6346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6290, 6346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6290, 6346);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
            f_10668_6293_6346()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<FieldSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 6293, 6346);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6431, 6471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6434, 6471);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6431, 6471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6431, 6471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6431, 6471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6558, 6565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6561, 6565);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6558, 6565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6558, 6565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6558, 6565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6707, 6747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6710, 6747);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6707, 6747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6707, 6747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6707, 6747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 6760, 7725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6918, 6979);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10668, 6918, 6978);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 6918, 6978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 6995, 7202);

                f_10668_6995_7201(ref attributes, f_10668_7070_7200(moduleBuilder.Compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7218, 7338);

                f_10668_7218_7337(ref attributes, f_10668_7293_7336(moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7354, 7394);

                var
                usageInfo = f_10668_7370_7393(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7408, 7714) || true) && (usageInfo != AttributeUsageInfo.Default)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10668, 7408, 7714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7485, 7699);

                    f_10668_7485_7698(ref attributes, f_10668_7568_7697(moduleBuilder.Compilation, usageInfo.ValidTargets, usageInfo.AllowMultiple, usageInfo.Inherited));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10668, 7408, 7714);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 6760, 7725);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10668_7070_7200(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7070, 7200);
                    return return_v;
                }


                int
                f_10668_6995_7201(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 6995, 7201);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10668_7293_7336(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SynthesizeEmbeddedAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7293, 7336);
                    return return_v;
                }


                int
                f_10668_7218_7337(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7218, 7337);
                    return 0;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10668_7370_7393(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7370, 7393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10668_7568_7697(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.AttributeTargets
                targets, bool
                allowMultiple, bool
                inherited)
                {
                    var return_v = this_param.SynthesizeAttributeUsageAttribute(targets, allowMultiple, inherited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7568, 7697);
                    return return_v;
                }


                int
                f_10668_7485_7698(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 7485, 7698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 6760, 7725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 6760, 7725);
            }
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 7796, 7835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7799, 7835);
                throw f_10668_7805_7835(); DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 7796, 7835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 7796, 7835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 7796, 7835);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10668_7805_7835()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 7805, 7835);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 7917, 7924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 7920, 7924);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 7917, 7924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 7917, 7924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 7917, 7924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedEmbeddedAttributeSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10668, 1003, 7932);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10668, 1003, 7932);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 1003, 7932);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10668, 1003, 7932);

        int
        f_10668_1527_1555(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 1527, 1555);
            return 0;
        }


        int
        f_10668_1570_1613(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 1570, 1613);
            return 0;
        }


        int
        f_10668_1628_1668(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 1628, 1668);
            return 0;
        }


        int
        f_10668_1683_1715(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 1683, 1715);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10668_2569_2581()
        {
            var return_v = Constructors;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 2569, 2581);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10668_2958_2984(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 2958, 2984);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10668_4205_4221()
        {
            var return_v = ContainingModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 4205, 4221);
            return return_v;
        }


        bool
        f_10668_4205_4237(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.AreLocalsZeroed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 4205, 4237);
            return return_v;
        }


        System.Runtime.InteropServices.CharSet
        f_10668_4357_4382()
        {
            var return_v = DefaultMarshallingCharSet;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10668, 4357, 4382);
            return return_v;
        }

    }
    internal sealed class SynthesizedEmbeddedAttributeSymbol : SynthesizedEmbeddedAttributeSymbolBase
    {
        private readonly ImmutableArray<MethodSymbol> _constructors;

        public SynthesizedEmbeddedAttributeSymbol(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol baseType)
        : base(f_10668_8490_8494_C(name), containingNamespace, containingModule, baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10668, 8268, 8733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 8569, 8722);

                _constructors = f_10668_8585_8721(f_10668_8621_8720(this, m => ImmutableArray<ParameterSymbol>.Empty));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10668, 8268, 8733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 8268, 8733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8268, 8733);
            }
        }

        public override ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 8803, 8819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 8806, 8819);
                    return _constructors; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 8803, 8819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 8803, 8819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8803, 8819);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 8864, 8872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 8867, 8872);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 8864, 8872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 8864, 8872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8864, 8872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 8940, 8948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 8943, 8948);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 8940, 8948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 8940, 8948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8940, 8948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedEmbeddedAttributeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10668, 8082, 8956);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10668, 8082, 8956);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8082, 8956);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10668, 8082, 8956);

        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorSymbol
        f_10668_8621_8720(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 8621, 8720);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10668_8585_8721(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorSymbol
        item)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 8585, 8721);
            return return_v;
        }


        static string
        f_10668_8490_8494_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10668, 8268, 8733);
            return return_v;
        }

    }
    internal sealed class SynthesizedEmbeddedAttributeConstructorSymbol : SynthesizedInstanceConstructor
    {
        private readonly ImmutableArray<ParameterSymbol> _parameters;

        internal SynthesizedEmbeddedAttributeConstructorSymbol(
                    NamedTypeSymbol containingType,
                    Func<MethodSymbol, ImmutableArray<ParameterSymbol>> getParameters) : base(f_10668_9355_9369_C(containingType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10668, 9154, 9440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 9395, 9429);

                _parameters = f_10668_9409_9428(getParameters, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10668, 9154, 9440);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 9154, 9440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 9154, 9440);
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 9511, 9525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 9514, 9525);
                    return _parameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 9511, 9525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 9511, 9525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 9511, 9525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10668, 9538, 9735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10668, 9670, 9724);

                f_10668_9670_9723(this, compilationState, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10668, 9538, 9735);

                int
                f_10668_9670_9723(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBodyCore(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 9670, 9723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10668, 9538, 9735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 9538, 9735);
            }
        }

        static SynthesizedEmbeddedAttributeConstructorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10668, 8964, 9742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10668, 8964, 9742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10668, 8964, 9742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10668, 8964, 9742);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10668_9409_9428(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorSymbol
        arg)
        {
            var return_v = this_param.Invoke((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)arg);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10668, 9409, 9428);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10668_9355_9369_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10668, 9154, 9440);
            return return_v;
        }

    }
}
