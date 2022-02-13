// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;
using System.Reflection.Metadata;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SignatureOnlyMethodSymbol : MethodSymbol
    {
        private readonly string _name;

        private readonly TypeSymbol _containingType;

        private readonly MethodKind _methodKind;

        private readonly Cci.CallingConvention _callingConvention;

        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly RefKind _refKind;

        private readonly bool _isInitOnly;

        private readonly TypeWithAnnotations _returnType;

        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        private readonly ImmutableArray<MethodSymbol> _explicitInterfaceImplementations;

        public SignatureOnlyMethodSymbol(
                    string name,
                    TypeSymbol containingType,
                    MethodKind methodKind,
                    Cci.CallingConvention callingConvention,
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    ImmutableArray<ParameterSymbol> parameters,
                    RefKind refKind,
                    bool isInitOnly,
                    TypeWithAnnotations returnType,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    ImmutableArray<MethodSymbol> explicitInterfaceImplementations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10152, 1388, 2621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 733, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 777, 792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 831, 842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 892, 910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 1096, 1104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 1137, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 1969, 2095);

                f_10152_1969_2094(returnType.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10152, 1982, 2093) || isInitOnly == CustomModifierUtils.HasIsExternalInitModifier(returnType.CustomModifiers)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2109, 2148);

                _callingConvention = callingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2162, 2195);

                _typeParameters = typeParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2209, 2228);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2242, 2267);

                _isInitOnly = isInitOnly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2281, 2306);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2320, 2361);

                _refCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2375, 2400);

                _parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2414, 2497);

                _explicitInterfaceImplementations = explicitInterfaceImplementations.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2511, 2544);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2558, 2583);

                _methodKind = methodKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2597, 2610);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10152, 1388, 2621);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 1388, 2621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 1388, 2621);
            }
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 2693, 2727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2699, 2725);

                    return _callingConvention;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 2693, 2727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 2633, 2729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 2633, 2729);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 2773, 2890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2779, 2888);

                    return f_10152_2786_2831(_callingConvention).CallingConvention == SignatureCallingConvention.VarArgs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 2773, 2890);

                    System.Reflection.Metadata.SignatureHeader
                    f_10152_2786_2831(Microsoft.Cci.CallingConvention
                    rawValue)
                    {
                        var return_v = new System.Reflection.Metadata.SignatureHeader((byte)rawValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10152, 2786, 2831);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 2741, 2892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 2741, 2892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 2943, 2968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 2949, 2966);

                    return f_10152_2956_2961() > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 2943, 2968);

                    int
                    f_10152_2956_2961()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 2956, 2961);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 2904, 2970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 2904, 2970);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3010, 3048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3016, 3046);

                    return _typeParameters.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3010, 3048);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 2982, 3050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 2982, 3050);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3131, 3162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3137, 3160);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3131, 3162);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3062, 3164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3062, 3164);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3211, 3251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3217, 3249);

                    return _returnType.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3211, 3251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3176, 3253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3176, 3253);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3299, 3323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3305, 3321);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3299, 3323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3265, 3325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3265, 3325);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3401, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3407, 3426);

                    return _returnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3401, 3428);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3337, 3430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3337, 3430);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3516, 3547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3519, 3547);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3516, 3547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3516, 3547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3516, 3547);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3633, 3666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3636, 3666);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3633, 3666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3633, 3666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3633, 3666);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3743, 3774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3746, 3774);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3743, 3774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3743, 3774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3743, 3774);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3855, 3890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3861, 3888);

                    return _refCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3855, 3890);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3787, 3892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3787, 3892);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 3965, 3992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 3971, 3990);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 3965, 3992);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 3904, 3994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 3904, 3994);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4086, 4135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4092, 4133);

                    return _explicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4086, 4135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4006, 4137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4006, 4137);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4191, 4222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4197, 4220);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4191, 4222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4149, 4224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4149, 4224);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4276, 4303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4282, 4301);

                    return _methodKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4276, 4303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4236, 4305);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4236, 4305);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4347, 4368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4353, 4366);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4347, 4368);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4317, 4370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4317, 4370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4440, 4479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4443, 4479);
                throw f_10152_4449_4479(); DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4440, 4479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4440, 4479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4440, 4479);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10152_4449_4479()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 4449, 4479);
                return return_v;
            }

        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4590, 4635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4596, 4633);

                    throw f_10152_4602_4632();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4590, 4635);

                    System.Exception
                    f_10152_4602_4632()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 4602, 4632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4547, 4637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4547, 4637);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4689, 4734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4695, 4732);

                    throw f_10152_4701_4731();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4689, 4734);

                    System.Exception
                    f_10152_4701_4731()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 4701, 4731);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4649, 4736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4649, 4736);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4832, 4877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4838, 4875);

                    throw f_10152_4844_4874();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4832, 4877);

                    System.Exception
                    f_10152_4844_4874()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 4844, 4874);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4748, 4879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4748, 4879);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4939, 4984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 4945, 4982);

                    throw f_10152_4951_4981();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4939, 4984);

                    System.Exception
                    f_10152_4951_4981()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 4951, 4981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4891, 4986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4891, 4986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 4998, 5063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5049, 5061);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 4998, 5063);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 4998, 5063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 4998, 5063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5162, 5207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5168, 5205);

                    throw f_10152_5174_5204();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5162, 5207);

                    System.Exception
                    f_10152_5174_5204()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5174, 5204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5075, 5209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5075, 5209);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5269, 5314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5275, 5312);

                    throw f_10152_5281_5311();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5269, 5314);

                    System.Exception
                    f_10152_5281_5311()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5281, 5311);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5221, 5316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5221, 5316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5328, 5457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5418, 5455);

                throw f_10152_5424_5454();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5328, 5457);

                System.Exception
                f_10152_5424_5454()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5424, 5454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5328, 5457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5328, 5457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5533, 5578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5539, 5576);

                    throw f_10152_5545_5575();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5533, 5578);

                    System.Exception
                    f_10152_5545_5575()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5545, 5575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5469, 5580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5469, 5580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5708, 5747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5711, 5747);
                throw f_10152_5717_5747(); DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5708, 5747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5708, 5747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5708, 5747);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10152_5717_5747()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5717, 5747);
                return return_v;
            }

        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5760, 5873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5834, 5871);

                throw f_10152_5840_5870();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5760, 5873);

                System.Exception
                f_10152_5840_5870()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5840, 5870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5760, 5873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5760, 5873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 5968, 6013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 5974, 6011);

                    throw f_10152_5980_6010();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 5968, 6013);

                    System.Exception
                    f_10152_5980_6010()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 5980, 6010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 5885, 6015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 5885, 6015);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6069, 6114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6075, 6112);

                    throw f_10152_6081_6111();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6069, 6114);

                    System.Exception
                    f_10152_6081_6111()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6081, 6111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6027, 6116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6027, 6116);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6169, 6214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6175, 6212);

                    throw f_10152_6181_6211();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6169, 6214);

                    System.Exception
                    f_10152_6181_6211()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6181, 6211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6128, 6216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6128, 6216);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6274, 6319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6280, 6317);

                    throw f_10152_6286_6316();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6274, 6319);

                    System.Exception
                    f_10152_6286_6316()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6286, 6316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6228, 6321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6228, 6321);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6386, 6431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6392, 6429);

                    throw f_10152_6398_6428();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6386, 6431);

                    System.Exception
                    f_10152_6398_6428()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6398, 6428);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6333, 6433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6333, 6433);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6521, 6566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6527, 6564);

                    throw f_10152_6533_6563();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6521, 6566);

                    System.Exception
                    f_10152_6533_6563()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6533, 6563);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6445, 6568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6445, 6568);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6634, 6679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6640, 6677);

                    throw f_10152_6646_6676();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6634, 6679);

                    System.Exception
                    f_10152_6646_6676()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6646, 6676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6580, 6681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6580, 6681);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6725, 6770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6731, 6768);

                    throw f_10152_6737_6767();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6725, 6770);

                    System.Exception
                    f_10152_6737_6767()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6737, 6767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6693, 6772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6693, 6772);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6815, 6860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6821, 6858);

                    throw f_10152_6827_6857();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6815, 6860);

                    System.Exception
                    f_10152_6827_6857()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6827, 6857);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6784, 6862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6784, 6862);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 6907, 6952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 6913, 6950);

                    throw f_10152_6919_6949();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 6907, 6952);

                    System.Exception
                    f_10152_6919_6949()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 6919, 6949);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6874, 6954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6874, 6954);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7000, 7045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7006, 7043);

                    throw f_10152_7012_7042();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7000, 7045);

                    System.Exception
                    f_10152_7012_7042()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7012, 7042);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 6966, 7047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 6966, 7047);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7093, 7138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7099, 7136);

                    throw f_10152_7105_7135();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7093, 7138);

                    System.Exception
                    f_10152_7105_7135()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7105, 7135);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7059, 7140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7059, 7140);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7184, 7229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7190, 7227);

                    throw f_10152_7196_7226();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7184, 7229);

                    System.Exception
                    f_10152_7196_7226()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7196, 7226);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7152, 7231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7152, 7231);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7275, 7320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7281, 7318);

                    throw f_10152_7287_7317();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7275, 7320);

                    System.Exception
                    f_10152_7287_7317()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7287, 7317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7243, 7322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7243, 7322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7373, 7418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7379, 7416);

                    throw f_10152_7385_7415();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7373, 7418);

                    System.Exception
                    f_10152_7385_7415()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7385, 7415);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7334, 7420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7334, 7420);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7484, 7529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7490, 7527);

                    throw f_10152_7496_7526();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7484, 7529);

                    System.Exception
                    f_10152_7496_7526()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7496, 7526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7432, 7531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7432, 7531);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7593, 7638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7599, 7636);

                    throw f_10152_7605_7635();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7593, 7638);

                    System.Exception
                    f_10152_7605_7635()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7605, 7635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7543, 7640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7543, 7640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7652, 7792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7753, 7790);

                throw f_10152_7759_7789();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7652, 7792);

                System.Exception
                f_10152_7759_7789()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7759, 7789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7652, 7792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7652, 7792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 7804, 7944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 7905, 7942);

                throw f_10152_7911_7941();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 7804, 7944);

                System.Exception
                f_10152_7911_7941()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 7911, 7941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7804, 7944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7804, 7944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 8019, 8107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 8055, 8092);

                    throw f_10152_8061_8091();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 8019, 8107);

                    System.Exception
                    f_10152_8061_8091()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 8061, 8091);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 7956, 8118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 7956, 8118);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 8172, 8180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 8175, 8180);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 8172, 8180);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 8172, 8180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 8172, 8180);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 8227, 8241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 8230, 8241);
                    return _isInitOnly; DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 8227, 8241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 8227, 8241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 8227, 8241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10152, 8254, 8385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10152, 8346, 8383);

                throw f_10152_8352_8382();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10152, 8254, 8385);

                System.Exception
                f_10152_8352_8382()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10152, 8352, 8382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10152, 8254, 8385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 8254, 8385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SignatureOnlyMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10152, 630, 8414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10152, 630, 8414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10152, 630, 8414);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10152, 630, 8414);

        int
        f_10152_1969_2094(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10152, 1969, 2094);
            return 0;
        }

    }
}
