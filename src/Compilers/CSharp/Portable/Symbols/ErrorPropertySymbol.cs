// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ErrorPropertySymbol : PropertySymbol
    {
        private readonly Symbol _containingSymbol;

        private readonly TypeWithAnnotations _typeWithAnnotations;

        private readonly string _name;

        private readonly bool _isIndexer;

        private readonly bool _isIndexedProperty;

        public ErrorPropertySymbol(Symbol containingSymbol, TypeSymbol type, string name, bool isIndexer, bool isIndexedProperty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10105, 1387, 1768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1155, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1275, 1280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1313, 1323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1356, 1374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1533, 1570);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1584, 1640);

                _typeWithAnnotations = TypeWithAnnotations.Create(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1654, 1667);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1681, 1704);

                _isIndexer = isIndexer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1718, 1757);

                _isIndexedProperty = isIndexedProperty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10105, 1387, 1768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 1387, 1768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 1387, 1768);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 1822, 1855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1828, 1853);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 1822, 1855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 1780, 1857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 1780, 1857);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 1903, 1931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 1909, 1929);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 1903, 1931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 1869, 1933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 1869, 1933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2003, 2039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2009, 2037);

                    return _typeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2003, 2039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 1945, 2041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 1945, 2041);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2083, 2104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2089, 2102);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2083, 2104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2053, 2106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2053, 2106);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2158, 2179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2164, 2177);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2158, 2179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2118, 2181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2118, 2181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2226, 2252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2232, 2250);

                    return _isIndexer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2226, 2252);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2193, 2254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2193, 2254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexedProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2307, 2341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2313, 2339);

                    return _isIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2307, 2341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2266, 2343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2266, 2343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2452, 2472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2458, 2470);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2452, 2472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2411, 2474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2411, 2474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol SetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2583, 2603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2589, 2601);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2583, 2603);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2542, 2605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2542, 2605);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2670, 2716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2676, 2714);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2670, 2716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2617, 2718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2617, 2718);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2806, 2859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2812, 2857);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2806, 2859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2730, 2861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2730, 2861);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 2927, 2970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 2933, 2968);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 2927, 2970);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2873, 2972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2873, 2972);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3016, 3037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3022, 3035);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3016, 3037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 2984, 3039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 2984, 3039);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3084, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3090, 3103);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3084, 3105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3051, 3107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3051, 3107);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3153, 3174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3159, 3172);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3153, 3174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3119, 3176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3119, 3176);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3222, 3243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3228, 3241);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3222, 3243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3188, 3245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3188, 3245);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3289, 3310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3295, 3308);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3289, 3310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3257, 3312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3257, 3312);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3356, 3377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3362, 3375);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3356, 3377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3324, 3379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3324, 3379);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3462, 3482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3468, 3480);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3462, 3482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3391, 3484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3391, 3484);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3557, 3610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3563, 3608);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3557, 3610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3496, 3612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3496, 3612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3684, 3729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3690, 3727);

                    return Cci.CallingConvention.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3684, 3729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3624, 3731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3624, 3731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3792, 3813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3798, 3811);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3792, 3813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3743, 3815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3743, 3815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 3909, 3961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 3915, 3959);

                    return ImmutableArray<PropertySymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 3909, 3961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3827, 3963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3827, 3963);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10105, 4043, 4095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10105, 4049, 4093);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10105, 4043, 4095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10105, 3975, 4097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 3975, 4097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ErrorPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10105, 1056, 4104);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10105, 1056, 4104);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10105, 1056, 4104);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10105, 1056, 4104);
    }
}
