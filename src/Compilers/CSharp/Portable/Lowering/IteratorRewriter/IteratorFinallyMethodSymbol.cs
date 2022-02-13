// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class IteratorFinallyMethodSymbol : SynthesizedInstanceMethodSymbol, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly IteratorStateMachine _stateMachineType;

        private readonly string _name;

        public IteratorFinallyMethodSymbol(IteratorStateMachine stateMachineType, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10466, 1590, 1880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1520, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1572, 1577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1701, 1748);

                f_10466_1701_1747((object)stateMachineType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1762, 1789);

                f_10466_1762_1788(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1805, 1842);

                _stateMachineType = stateMachineType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1856, 1869);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10466, 1590, 1880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 1590, 1880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 1590, 1880);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 1944, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 1980, 1993);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 1944, 2008);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 1892, 2019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 1892, 2019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2031, 2171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2147, 2160);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2031, 2171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2031, 2171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2031, 2171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2183, 2323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2299, 2312);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2183, 2323);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2183, 2323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2183, 2323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2398, 2462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2434, 2447);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2398, 2462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2335, 2473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2335, 2473);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2547, 2582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2553, 2580);

                    return MethodKind.Ordinary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2547, 2582);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2485, 2593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2485, 2593);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2655, 2672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2661, 2670);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2655, 2672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2605, 2683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2605, 2683);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2758, 2779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2764, 2777);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2758, 2779);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2695, 2790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2695, 2790);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 2864, 2885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 2870, 2883);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 2864, 2885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2802, 2896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2802, 2896);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3014, 3077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3020, 3075);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3014, 3077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 2908, 3088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 2908, 3088);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3170, 3191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3176, 3189);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3170, 3191);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3100, 3202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3100, 3202);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3214, 3310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3287, 3299);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3214, 3310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3214, 3310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3214, 3310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3322, 3472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3424, 3461);

                throw f_10466_3430_3460();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3322, 3472);

                System.Exception
                f_10466_3430_3460()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10466, 3430, 3460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3322, 3472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3322, 3472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3593, 3613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3599, 3611);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3593, 3613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3484, 3624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3484, 3624);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3706, 3727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3712, 3725);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3706, 3727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3636, 3738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3636, 3738);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3818, 3839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3824, 3837);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3818, 3839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3750, 3850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3750, 3850);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 3916, 3937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 3922, 3935);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 3916, 3937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3862, 3948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3862, 3948);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4017, 4037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4023, 4035);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4017, 4037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 3960, 4048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 3960, 4048);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4113, 4134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4119, 4132);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4113, 4134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4060, 4145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4060, 4145);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4213, 4241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4219, 4239);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4213, 4241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4157, 4252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4157, 4252);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4350, 4452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4356, 4450);

                    return TypeWithAnnotations.Create(f_10466_4390_4448(f_10466_4390_4408(), SpecialType.System_Void));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4350, 4452);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10466_4390_4408()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10466, 4390, 4408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10466_4390_4448(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10466, 4390, 4448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4264, 4463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4264, 4463);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4549, 4580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4552, 4580);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4549, 4580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4549, 4580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4549, 4580);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4666, 4699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4669, 4699);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4666, 4699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4666, 4699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4666, 4699);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4817, 4874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4823, 4872);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4817, 4874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4712, 4885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4712, 4885);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 4988, 5045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 4994, 5043);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 4988, 5045);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 4897, 5056);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 4897, 5056);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5151, 5204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5157, 5202);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5151, 5204);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5068, 5215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5068, 5215);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5329, 5379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5335, 5377);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5329, 5379);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5227, 5390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5227, 5390);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5492, 5544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5498, 5542);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5492, 5544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5402, 5555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5402, 5555);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5631, 5651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5637, 5649);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5631, 5651);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5567, 5662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5567, 5662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5674, 5817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5770, 5806);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5674, 5817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5674, 5817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5674, 5817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 5911, 5956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 5917, 5954);

                    return Cci.CallingConvention.HasThis;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 5911, 5956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5829, 5967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5829, 5967);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6044, 6064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6050, 6062);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6044, 6064);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 5979, 6075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 5979, 6075);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6151, 6184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6157, 6182);

                    return _stateMachineType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6151, 6184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6087, 6195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6087, 6195);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6282, 6322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6288, 6320);

                    return f_10466_6295_6319(f_10466_6295_6309());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6282, 6322);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10466_6295_6309()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10466, 6295, 6309);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10466_6295_6319(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10466, 6295, 6319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6207, 6333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6207, 6333);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6421, 6458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6427, 6456);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6421, 6458);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6345, 6469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6345, 6469);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6535, 6556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6541, 6554);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6535, 6556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6481, 6567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6481, 6567);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6634, 6655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6640, 6653);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6634, 6655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6579, 6666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6579, 6666);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6734, 6755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6740, 6753);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6734, 6755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6678, 6766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6678, 6766);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6834, 6855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6840, 6853);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6834, 6855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6778, 6866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6778, 6866);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 6932, 6953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 6938, 6951);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 6932, 6953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6878, 6964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6878, 6964);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 7030, 7051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 7036, 7049);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 7030, 7051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 6976, 7062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 6976, 7062);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 7170, 7217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 7176, 7215);

                    return _stateMachineType.KickoffMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 7170, 7217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 7074, 7228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 7074, 7228);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 7336, 7356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 7342, 7354);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 7336, 7356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 7240, 7367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 7240, 7367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10466, 7379, 7596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10466, 7493, 7585);

                return f_10466_7500_7584(_stateMachineType.KickoffMethod, localPosition, localTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10466, 7379, 7596);

                int
                f_10466_7500_7584(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10466, 7500, 7584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10466, 7379, 7596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 7379, 7596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IteratorFinallyMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10466, 1338, 7603);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10466, 1338, 7603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10466, 1338, 7603);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10466, 1338, 7603);

        int
        f_10466_1701_1747(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10466, 1701, 1747);
            return 0;
        }


        int
        f_10466_1762_1788(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10466, 1762, 1788);
            return 0;
        }

    }
}
