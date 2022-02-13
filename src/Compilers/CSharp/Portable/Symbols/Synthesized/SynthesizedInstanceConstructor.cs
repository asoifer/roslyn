// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SynthesizedInstanceConstructor : SynthesizedInstanceMethodSymbol
    {
        private readonly NamedTypeSymbol _containingType;

        internal SynthesizedInstanceConstructor(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10681, 613, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 585, 600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 709, 754);

                f_10681_709_753((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 768, 801);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10681, 613, 812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 613, 812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 613, 812);
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 989, 1009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 995, 1007);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 989, 1009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 924, 1020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 924, 1020);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1115, 1168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1121, 1166);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1115, 1168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1032, 1179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1032, 1179);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1267, 1357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1273, 1355);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10681, 1280, 1305) || ((f_10681_1280_1305(f_10681_1280_1294()) && DynAbs.Tracing.TraceSender.Conditional_F2(10681, 1308, 1331)) || DynAbs.Tracing.TraceSender.Conditional_F3(10681, 1334, 1354))) ? Accessibility.Protected : Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1267, 1357);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10681_1280_1294()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 1280, 1294);
                        return return_v;
                    }


                    bool
                    f_10681_1280_1305(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 1280, 1305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1191, 1368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1191, 1368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1443, 1507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1479, 1492);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1443, 1507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1380, 1518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1380, 1518);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1627, 1658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1633, 1656);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1627, 1658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1556, 1669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1556, 1669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1759, 1833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1795, 1818);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1759, 1833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1681, 1844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1681, 1844);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 1915, 1975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 1921, 1973);

                    return WellKnownMemberNames.InstanceConstructorName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 1915, 1975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1856, 1986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1856, 1986);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 2067, 2087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2073, 2085);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 2067, 2087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 1998, 2098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 1998, 2098);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 2223, 2812);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2259, 2538) || true) && (f_10681_2263_2290(_containingType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10681, 2259, 2538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2332, 2389);

                        f_10681_2332_2388(f_10681_2345_2369(_containingType) == TypeKind.Class);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2411, 2519);

                        return System.Reflection.MethodImplAttributes.Runtime | System.Reflection.MethodImplAttributes.InternalCall;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10681, 2259, 2538);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2558, 2722) || true) && (f_10681_2562_2586(_containingType) == TypeKind.Delegate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10681, 2558, 2722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2649, 2703);

                        return System.Reflection.MethodImplAttributes.Runtime;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10681, 2558, 2722);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2742, 2797);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 2223, 2812);

                    bool
                    f_10681_2263_2290(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 2263, 2290);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10681_2345_2369(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 2345, 2369);
                        return return_v;
                    }


                    int
                    f_10681_2332_2388(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 2332, 2388);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10681_2562_2586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 2562, 2586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 2110, 2823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 2110, 2823);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 2912, 2933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 2918, 2931);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 2912, 2933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 2835, 2944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 2835, 2944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 2956, 3059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3036, 3048);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 2956, 3059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 2956, 3059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 2956, 3059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3187, 3207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3193, 3205);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3187, 3207);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3071, 3218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3071, 3218);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3307, 3328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3313, 3326);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3307, 3328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3230, 3339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3230, 3339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3351, 3508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3460, 3497);

                throw f_10681_3466_3496();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3351, 3508);

                System.Exception
                f_10681_3466_3496()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 3466, 3496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3351, 3508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3351, 3508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3520, 3670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3623, 3659);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3520, 3670);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3520, 3670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3520, 3670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3743, 3764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3749, 3762);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3743, 3764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3682, 3775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3682, 3775);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3885, 3942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 3891, 3940);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3885, 3942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3787, 3953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3787, 3953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 3965, 4332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 4283, 4321);

                return LexicalSortKey.SynthesizedCtor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 3965, 4332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 3965, 4332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 3965, 4332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 4426, 4466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 4432, 4464);

                    return f_10681_4439_4463(f_10681_4439_4453());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 4426, 4466);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10681_4439_4453()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 4439, 4453);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10681_4439_4463(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 4439, 4463);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 4344, 4477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 4344, 4477);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 4545, 4573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 4551, 4571);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 4545, 4573);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 4489, 4584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 4489, 4584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 4689, 4791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 4695, 4789);

                    return TypeWithAnnotations.Create(f_10681_4729_4787(f_10681_4729_4747(), SpecialType.System_Void));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 4689, 4791);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10681_4729_4747()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 4729, 4747);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10681_4729_4787(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 4729, 4787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 4596, 4802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 4596, 4802);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 4895, 4926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 4898, 4926);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 4895, 4926);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 4895, 4926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 4895, 4926);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5019, 5052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5022, 5052);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5019, 5052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5019, 5052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5019, 5052);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5155, 5207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5161, 5205);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5155, 5207);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5065, 5218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5065, 5218);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5342, 5399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5348, 5397);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5342, 5399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5230, 5410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5230, 5410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5493, 5513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5499, 5511);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5493, 5513);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5422, 5524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5422, 5524);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5593, 5610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5599, 5608);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5593, 5610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5536, 5621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5536, 5621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5697, 5717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5703, 5715);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5697, 5717);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5633, 5728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5633, 5728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5809, 5847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 5815, 5845);

                    return MethodKind.Constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5809, 5847);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5740, 5858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5740, 5858);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 5931, 6195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6041, 6094);

                    NamedTypeSymbol
                    containingType = f_10681_6074_6093(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6112, 6180);

                    return (object)containingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10681, 6119, 6179) && f_10681_6153_6179(containingType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 5931, 6195);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10681_6074_6093(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 6074, 6093);
                        return return_v;
                    }


                    bool
                    f_10681_6153_6179(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 6153, 6179);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 5870, 6206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 5870, 6206);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6279, 6300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6285, 6298);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6279, 6300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6218, 6311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6218, 6311);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6386, 6407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6392, 6405);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6386, 6407);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6323, 6418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6323, 6418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6493, 6514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6499, 6512);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6493, 6514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6430, 6525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6430, 6525);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6599, 6620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6605, 6618);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6599, 6620);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6537, 6631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6537, 6631);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6704, 6725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6710, 6723);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6704, 6725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6643, 6736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6643, 6736);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6808, 6829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6814, 6827);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6808, 6829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6748, 6840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6748, 6840);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6927, 6948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 6933, 6946);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6927, 6948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6852, 6959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6852, 6959);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 6971, 7118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7094, 7107);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 6971, 7118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 6971, 7118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 6971, 7118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7130, 7277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7253, 7266);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7130, 7277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7130, 7277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7130, 7277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7359, 7380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7365, 7378);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7359, 7380);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7289, 7391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7289, 7391);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7492, 7537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7498, 7535);

                    return Cci.CallingConvention.HasThis;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7492, 7537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7403, 7548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7403, 7548);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7648, 7669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7654, 7667);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7648, 7669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7560, 7680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7560, 7680);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7801, 7851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7807, 7849);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7801, 7851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7692, 7862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7692, 7862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 7874, 8205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 7995, 8069);

                var
                containingType = (SourceMemberContainerTypeSymbol)f_10681_8049_8068(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 8083, 8194);

                return f_10681_8090_8193(containingType, localPosition, localTree, isStatic: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 7874, 8205);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10681_8049_8068(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 8049, 8068);
                    return return_v;
                }


                int
                f_10681_8090_8193(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxTree
                tree, bool
                isStatic)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInSynthesizedConstructor(position, tree, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 8090, 8193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 7874, 8205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 7874, 8205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 8217, 8376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 8304, 8365);

                return f_10681_8311_8364(f_10681_8311_8336().Type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 8217, 8376);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10681_8311_8336()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 8311, 8336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10681_8311_8364(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 8311, 8364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 8217, 8376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 8217, 8376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 8465, 8672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 8481, 8672);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10681, 8481, 8532) || (((f_10681_8482_8496() is SourceMemberContainerTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10681, 8549, 8664)) || DynAbs.Tracing.TraceSender.Conditional_F3(10681, 8667, 8672))) ? f_10681_8549_8664(((SourceMemberContainerTypeSymbol)f_10681_8583_8597()), useStatic: false) : false; DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 8465, 8672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 8465, 8672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 8465, 8672);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10681_8482_8496()
            {
                var return_v = ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 8482, 8496);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10681_8583_8597()
            {
                var return_v = ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 8583, 8597);
                return return_v;
            }


            bool
            f_10681_8549_8664(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            this_param, bool
            useStatic)
            {
                var return_v = this_param.IsNullableEnabledForConstructorsAndInitializers(useStatic: useStatic);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 8549, 8664);
                return return_v;
            }

        }

        protected void GenerateMethodBodyCore(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 8707, 10020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 8835, 8945);

                var
                factory = f_10681_8849_8944(this, f_10681_8885_8912(this), compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 8959, 8990);

                factory.CurrentFunction = this;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9004, 9262) || true) && (f_10681_9008_9051(f_10681_9008_9022()) is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10681, 9004, 9262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9185, 9222);

                    f_10681_9185_9221(                // System_Attribute was not found or was inaccessible
                                    factory, f_10681_9205_9220(factory));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9240, 9247);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10681, 9004, 9262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9278, 9386);

                var
                baseConstructorCall = f_10681_9304_9385(this, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9400, 9612) || true) && (baseConstructorCall == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10681, 9400, 9612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9535, 9572);

                    f_10681_9535_9571(                // Attribute..ctor was not found or was inaccessible
                                    factory, f_10681_9555_9570(factory));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9590, 9597);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10681, 9400, 9612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9628, 9688);

                var
                statements = f_10681_9645_9687()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9702, 9767);

                f_10681_9702_9766(statements, f_10681_9717_9765(factory, baseConstructorCall));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9781, 9844);

                f_10681_9781_9843(this, factory, statements, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9858, 9891);

                f_10681_9858_9890(statements, f_10681_9873_9889(factory));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9907, 9966);

                var
                block = f_10681_9919_9965(factory, f_10681_9933_9964(statements))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10681, 9982, 10009);

                f_10681_9982_10008(
                            factory, block);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 8707, 10020);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10681_8885_8912(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 8885, 8912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10681_8849_8944(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 8849, 8944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10681_9008_9022()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 9008, 9022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10681_9008_9051(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10681, 9008, 9051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10681_9205_9220(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9205, 9220);
                    return return_v;
                }


                int
                f_10681_9185_9221(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9185, 9221);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10681_9304_9385(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                constructor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = MethodCompiler.GenerateBaseParameterlessConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)constructor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9304, 9385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10681_9555_9570(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9555, 9570);
                    return return_v;
                }


                int
                f_10681_9535_9571(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9535, 9571);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10681_9645_9687()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9645, 9687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10681_9717_9765(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9717, 9765);
                    return return_v;
                }


                int
                f_10681_9702_9766(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9702, 9766);
                    return 0;
                }


                int
                f_10681_9781_9843(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBodyStatements(factory, statements, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9781, 9843);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10681_9873_9889(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9873, 9889);
                    return return_v;
                }


                int
                f_10681_9858_9890(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9858, 9890);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10681_9933_9964(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9933, 9964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10681_9919_9965(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9919, 9965);
                    return return_v;
                }


                int
                f_10681_9982_10008(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 9982, 10008);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 8707, 10020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 8707, 10020);
            }
        }

        internal virtual void GenerateMethodBodyStatements(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10681, 10032, 10318);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10681, 10032, 10318);
                // overridden in a derived class to add extra statements to the body of the generated constructor
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10681, 10032, 10318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 10032, 10318);
            }
        }

        static SynthesizedInstanceConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10681, 456, 10327);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10681, 456, 10327);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10681, 456, 10327);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10681, 456, 10327);

        int
        f_10681_709_753(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10681, 709, 753);
            return 0;
        }

    }
}
