// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedStaticConstructor : MethodSymbol
    {
        private readonly NamedTypeSymbol _containingType;

        private ThreeState _lazyShouldEmit;

        internal SynthesizedStaticConstructor(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10690, 599, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 505, 520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 550, 586);
                this._lazyShouldEmit = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 693, 726);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10690, 599, 737);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 599, 737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 599, 737);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 813, 887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 849, 872);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 813, 887);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 749, 898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 749, 898);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 981, 1055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1017, 1040);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 981, 1055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 910, 1066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 910, 1066);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1130, 1231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1166, 1216);

                    return WellKnownMemberNames.StaticConstructorName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1130, 1231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1078, 1242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1078, 1242);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1316, 1336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1322, 1334);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1316, 1336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1254, 1347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1254, 1347);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1465, 1528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1471, 1526);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1465, 1528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1359, 1539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1359, 1539);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1605, 1669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1641, 1654);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1605, 1669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1551, 1680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1551, 1680);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1783, 1883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 1819, 1868);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1783, 1883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1692, 1894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1692, 1894);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 1967, 2027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 2003, 2012);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 1967, 2027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 1906, 2038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 1906, 2038);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 2133, 2229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 2169, 2214);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 2133, 2229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 2050, 2240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 2050, 2240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool TryGetThisParameter(out ParameterSymbol? thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 2252, 2413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 2355, 2376);

                thisParameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 2390, 2402);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 2252, 2413);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 2252, 2413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 2252, 2413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 2501, 2715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 2671, 2700);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 2501, 2715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 2425, 2726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 2425, 2726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 2738, 3106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3056, 3095);

                return LexicalSortKey.SynthesizedCCtor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 2738, 3106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 2738, 3106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 2738, 3106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 3193, 3276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3229, 3261);

                    return f_10690_3236_3260(f_10690_3236_3250());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 3193, 3276);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10690_3236_3250()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 3236, 3250);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10690_3236_3260(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 3236, 3260);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 3118, 3287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 3118, 3287);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 3397, 3493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3433, 3478);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 3397, 3493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 3299, 3504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 3299, 3504);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 3572, 3643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3608, 3628);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 3572, 3643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 3516, 3654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 3516, 3654);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 3752, 3897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3788, 3882);

                    return TypeWithAnnotations.Create(f_10690_3822_3880(f_10690_3822_3840(), SpecialType.System_Void));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 3752, 3897);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10690_3822_3840()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 3822, 3840);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10690_3822_3880(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 3822, 3880);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 3666, 3908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 3666, 3908);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 3994, 4025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 3997, 4025);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 3994, 4025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 3994, 4025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 3994, 4025);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4111, 4144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4114, 4144);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4111, 4144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4111, 4144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4111, 4144);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4221, 4252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4224, 4252);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4221, 4252);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4221, 4252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4221, 4252);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4355, 4450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4391, 4435);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4355, 4450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4265, 4461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4265, 4461);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4578, 4678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4614, 4663);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4578, 4678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4473, 4689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4473, 4689);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4766, 4829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4802, 4814);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4766, 4829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4701, 4840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4701, 4840);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 4902, 4962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 4938, 4947);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 4902, 4962);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4852, 4973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4852, 4973);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5042, 5105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5078, 5090);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5042, 5105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 4985, 5116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 4985, 5116);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5190, 5277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5226, 5262);

                    return MethodKind.StaticConstructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5190, 5277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5128, 5288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5128, 5288);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5354, 5418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5390, 5403);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5354, 5418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5300, 5429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5300, 5429);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5495, 5559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5531, 5544);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5495, 5559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5441, 5570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5441, 5570);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5638, 5702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5674, 5687);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5638, 5702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5582, 5713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5582, 5713);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5781, 5845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5817, 5830);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5781, 5845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5725, 5856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5725, 5856);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 5923, 5987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 5959, 5972);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 5923, 5987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 5868, 5998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 5868, 5998);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6064, 6127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6100, 6112);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6064, 6127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6010, 6138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6010, 6138);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6203, 6267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6239, 6252);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6203, 6267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6150, 6278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6150, 6278);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6358, 6422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6394, 6407);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6358, 6422);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6290, 6433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6290, 6433);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6508, 6572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6544, 6557);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6508, 6572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6445, 6583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6445, 6583);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6687, 6886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6824, 6871);

                    return Microsoft.Cci.CallingConvention.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6687, 6886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6595, 6897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6595, 6897);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 6990, 7011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 6996, 7009);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 6990, 7011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 6909, 7022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 6909, 7022);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7136, 7229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7172, 7214);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7136, 7229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7034, 7240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7034, 7240);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7294, 7302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7297, 7302);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7294, 7302);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7294, 7302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7294, 7302);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7349, 7357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7352, 7357);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7349, 7357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7349, 7357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7349, 7357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7443, 7506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7479, 7491);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7443, 7506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7370, 7517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7370, 7517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7601, 7720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7693, 7705);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7601, 7720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7529, 7731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7529, 7731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7743, 7890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 7866, 7879);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7743, 7890);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7743, 7890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7743, 7890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 7902, 8049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8025, 8038);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 7902, 8049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 7902, 8049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 7902, 8049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8124, 8188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8160, 8173);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8124, 8188);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8061, 8199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8061, 8199);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8281, 8345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8317, 8330);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8281, 8345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8211, 8356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8211, 8356);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData? GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8368, 8465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8442, 8454);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8368, 8465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8368, 8465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8368, 8465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8545, 8591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8551, 8589);

                    return f_10690_8558_8588(f_10690_8558_8572());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8545, 8591);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10690_8558_8572()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 8558, 8572);
                        return return_v;
                    }


                    bool
                    f_10690_8558_8588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 8558, 8588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8477, 8602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8477, 8602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData? ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8724, 8744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8730, 8742);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8724, 8744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8614, 8755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8614, 8755);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8837, 8858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8843, 8856);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8837, 8858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8767, 8869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8767, 8869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 8881, 9041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 8993, 9030);

                throw f_10690_8999_9029();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 8881, 9041);

                System.Exception
                f_10690_8999_9029()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 8999, 9029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 8881, 9041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 8881, 9041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 9147, 9167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9153, 9165);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 9147, 9167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 9053, 9178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 9053, 9178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 9307, 9314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9310, 9314);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 9307, 9314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 9307, 9314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 9307, 9314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 9327, 9470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9423, 9459);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 9327, 9470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 9327, 9470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 9327, 9470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 9482, 9805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9596, 9670);

                var
                containingType = (SourceMemberContainerTypeSymbol)f_10690_9650_9669(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9684, 9794);

                return f_10690_9691_9793(containingType, localPosition, localTree, isStatic: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 9482, 9805);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10690_9650_9669(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 9650, 9669);
                    return return_v;
                }


                int
                f_10690_9691_9793(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxTree
                tree, bool
                isStatic)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInSynthesizedConstructor(position, tree, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 9691, 9793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 9482, 9805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 9482, 9805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 9894, 10100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 9910, 10100);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10690, 9910, 9961) || (((f_10690_9911_9925() is SourceMemberContainerTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10690, 9978, 10092)) || DynAbs.Tracing.TraceSender.Conditional_F3(10690, 10095, 10100))) ? f_10690_9978_10092(((SourceMemberContainerTypeSymbol)f_10690_10012_10026()), useStatic: true) : false; DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 9894, 10100);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 9894, 10100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 9894, 10100);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10690_9911_9925()
            {
                var return_v = ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 9911, 9925);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10690_10012_10026()
            {
                var return_v = ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 10012, 10026);
                return return_v;
            }


            bool
            f_10690_9978_10092(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            this_param, bool
            useStatic)
            {
                var return_v = this_param.IsNullableEnabledForConstructorsAndInitializers(useStatic: useStatic);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 9978, 10092);
                return return_v;
            }

        }

        internal bool ShouldEmit(ImmutableArray<BoundInitializer> boundInitializersOpt = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 10113, 10513);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10227, 10337) || true) && (f_10690_10231_10257(_lazyShouldEmit))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 10227, 10337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10291, 10322);

                    return f_10690_10298_10321(_lazyShouldEmit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 10227, 10337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10353, 10412);

                var
                shouldEmit = f_10690_10370_10411(this, boundInitializersOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10426, 10470);

                _lazyShouldEmit = f_10690_10444_10469(shouldEmit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10484, 10502);

                return shouldEmit;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 10113, 10513);

                bool
                f_10690_10231_10257(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10231, 10257);
                    return return_v;
                }


                bool
                f_10690_10298_10321(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.Value();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10298, 10321);
                    return return_v;
                }


                bool
                f_10690_10370_10411(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializersOpt)
                {
                    var return_v = this_param.CalculateShouldEmit(boundInitializersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10370, 10411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10690_10444_10469(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10444, 10469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 10113, 10513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 10113, 10513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CalculateShouldEmit(ImmutableArray<BoundInitializer> boundInitializersOpt = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10690, 10525, 11968);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10647, 11393) || true) && (boundInitializersOpt.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 10647, 11393);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10715, 10939) || true) && (!(f_10690_10721_10735() is SourceMemberContainerTypeSymbol sourceType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 10715, 10939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10824, 10886);

                        f_10690_10824_10885(f_10690_10837_10851() is SynthesizedClosureEnvironment);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10908, 10920);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 10715, 10939);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 10959, 11011);

                    var
                    unusedDiagnostics = f_10690_10983_11010()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11029, 11335);

                    boundInitializersOpt = f_10690_11052_11334(f_10690_11103_11123(), (DynAbs.Tracing.TraceSender.Conditional_F1(10690, 11146, 11170) || ((f_10690_11146_11170(sourceType) && DynAbs.Tracing.TraceSender.Conditional_F2(10690, 11173, 11206)) || DynAbs.Tracing.TraceSender.Conditional_F3(10690, 11209, 11213))) ? f_10690_11173_11206(sourceType) : null, f_10690_11236_11265(sourceType), unusedDiagnostics, out _);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11353, 11378);

                    f_10690_11353_11377(unusedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 10647, 11393);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11409, 11928);
                    foreach (var initializer in f_10690_11437_11457_I(boundInitializersOpt))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 11409, 11928);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11491, 11793) || true) && (!(initializer is BoundFieldEqualsValue { Value: { } value }))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 11491, 11793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11762, 11774);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 11491, 11793);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11813, 11913) || true) && (!f_10690_11818_11840(value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10690, 11813, 11913);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11882, 11894);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 11813, 11913);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10690, 11409, 11928);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10690, 1, 520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10690, 1, 520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10690, 11944, 11957);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10690, 10525, 11968);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10690_10721_10735()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 10721, 10735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10690_10837_10851()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 10837, 10851);
                    return return_v;
                }


                int
                f_10690_10824_10885(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10824, 10885);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10690_10983_11010()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 10983, 11010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10690_11103_11123()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 11103, 11123);
                    return return_v;
                }


                bool
                f_10690_11146_11170(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 11146, 11170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                f_10690_11173_11206(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetScriptInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 11173, 11206);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10690_11236_11265(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.StaticInitializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10690, 11236, 11265);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10690_11052_11334(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod?
                scriptInitializerOpt, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                initializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.ImportChain?
                firstImportChain)
                {
                    var return_v = Binder.BindFieldInitializers(compilation, scriptInitializerOpt, initializers, diagnostics, out firstImportChain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 11052, 11334);
                    return return_v;
                }


                int
                f_10690_11353_11377(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 11353, 11377);
                    return 0;
                }


                bool
                f_10690_11818_11840(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 11818, 11840);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10690_11437_11457_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10690, 11437, 11457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10690, 10525, 11968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 10525, 11968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedStaticConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10690, 390, 11975);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10690, 390, 11975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10690, 390, 11975);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10690, 390, 11975);
    }
}
