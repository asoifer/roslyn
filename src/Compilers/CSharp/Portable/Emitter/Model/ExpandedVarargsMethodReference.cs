// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class ExpandedVarargsMethodReference :
            Cci.IMethodReference,
            Cci.IGenericMethodInstanceReference,
            Cci.ISpecializedMethodReference
    {
        private readonly Cci.IMethodReference _underlyingMethod;

        private readonly ImmutableArray<Cci.IParameterTypeInformation> _argListParams;

        public ExpandedVarargsMethodReference(Cci.IMethodReference underlyingMethod, ImmutableArray<Cci.IParameterTypeInformation> argListParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10186, 891, 1266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 773, 790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1053, 1106);

                f_10186_1053_1105(f_10186_1066_1104(underlyingMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1120, 1157);

                f_10186_1120_1156(f_10186_1133_1155_M(!argListParams.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1173, 1210);

                _underlyingMethod = underlyingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1224, 1255);

                _argListParams = argListParams;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10186, 891, 1266);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 891, 1266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 891, 1266);
            }
        }

        bool Cci.IMethodReference.AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 1350, 1405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1356, 1403);

                    return f_10186_1363_1402(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 1350, 1405);

                    bool
                    f_10186_1363_1402(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AcceptsExtraArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 1363, 1402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 1278, 1416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 1278, 1416);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.IMethodReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 1502, 1557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1508, 1555);

                    return f_10186_1515_1554(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 1502, 1557);

                    ushort
                    f_10186_1515_1554(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.GenericParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 1515, 1554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 1428, 1568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 1428, 1568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodReference.IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 1640, 1683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1646, 1681);

                    return f_10186_1653_1680(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 1640, 1683);

                    bool
                    f_10186_1653_1680(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.IsGeneric;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 1653, 1680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 1580, 1694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 1580, 1694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodDefinition Cci.IMethodReference.GetResolvedMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 1706, 1875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 1812, 1864);

                return f_10186_1819_1863(_underlyingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 1706, 1875);

                Microsoft.Cci.IMethodDefinition?
                f_10186_1819_1863(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetResolvedMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 1819, 1863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 1706, 1875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 1706, 1875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.IMethodReference.ExtraParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 1994, 2067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2030, 2052);

                    return _argListParams;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 1994, 2067);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 1887, 2078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 1887, 2078);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericMethodInstanceReference Cci.IMethodReference.AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 2204, 2526);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2240, 2375) || true) && (f_10186_2244_2294(_underlyingMethod) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 2240, 2375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2344, 2356);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 2240, 2375);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2395, 2481);

                    f_10186_2395_2480(f_10186_2408_2458(_underlyingMethod) == _underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2499, 2511);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 2204, 2526);

                    Microsoft.Cci.IGenericMethodInstanceReference?
                    f_10186_2244_2294(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsGenericMethodInstanceReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 2244, 2294);
                        return return_v;
                    }


                    Microsoft.Cci.IGenericMethodInstanceReference
                    f_10186_2408_2458(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsGenericMethodInstanceReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 2408, 2458);
                        return return_v;
                    }


                    int
                    f_10186_2395_2480(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 2395, 2480);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 2090, 2537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 2090, 2537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedMethodReference Cci.IMethodReference.AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 2655, 2969);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2691, 2822) || true) && (f_10186_2695_2741(_underlyingMethod) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 2691, 2822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2791, 2803);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 2691, 2822);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2842, 2924);

                    f_10186_2842_2923(f_10186_2855_2901(_underlyingMethod) == _underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 2942, 2954);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 2655, 2969);

                    Microsoft.Cci.ISpecializedMethodReference?
                    f_10186_2695_2741(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsSpecializedMethodReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 2695, 2741);
                        return return_v;
                    }


                    Microsoft.Cci.ISpecializedMethodReference
                    f_10186_2855_2901(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsSpecializedMethodReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 2855, 2901);
                        return return_v;
                    }


                    int
                    f_10186_2842_2923(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 2842, 2923);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 2549, 2980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 2549, 2980);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.CallingConvention Cci.ISignature.CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3071, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3077, 3120);

                    return f_10186_3084_3119(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3071, 3122);

                    Microsoft.Cci.CallingConvention
                    f_10186_3084_3119(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 3084, 3119);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 2992, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 2992, 3133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ISignature.ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3206, 3254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3212, 3252);

                    return f_10186_3219_3251(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3206, 3254);

                    ushort
                    f_10186_3219_3251(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 3219, 3251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3145, 3265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3145, 3265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3277, 3456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3397, 3445);

                return f_10186_3404_3444(_underlyingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3277, 3456);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10186_3404_3444(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetParameters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 3404, 3444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3277, 3456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3277, 3456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3570, 3630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3576, 3628);

                    return f_10186_3583_3627(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3570, 3630);

                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                    f_10186_3583_3627(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.ReturnValueCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 3583, 3627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3468, 3641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3468, 3641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3747, 3799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3753, 3797);

                    return f_10186_3760_3796(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3747, 3799);

                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                    f_10186_3760_3796(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 3760, 3796);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3653, 3810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3653, 3810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ISignature.ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3885, 3937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 3891, 3935);

                    return f_10186_3898_3934(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3885, 3937);

                    bool
                    f_10186_3898_3934(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsByRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 3898, 3934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3822, 3948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3822, 3948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 3960, 4100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4047, 4089);

                return f_10186_4054_4088(_underlyingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 3960, 4100);

                Microsoft.Cci.ITypeReference
                f_10186_4054_4088(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4054, 4088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 3960, 4100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 3960, 4100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 4112, 4282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4219, 4271);

                return f_10186_4226_4270(_underlyingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 4112, 4282);

                Microsoft.Cci.ITypeReference
                f_10186_4226_4270(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4226, 4270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 4112, 4282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 4112, 4282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 4294, 4461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4402, 4450);

                return f_10186_4409_4449(_underlyingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 4294, 4461);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_10186_4409_4449(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4409, 4449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 4294, 4461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 4294, 4461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 4473, 5043);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4555, 5032) || true) && (f_10186_4559_4620(((Cci.IMethodReference)this)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 4555, 5032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4662, 4719);

                    f_10186_4662_4718(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 4555, 5032);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 4555, 5032);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4753, 5032) || true) && (f_10186_4757_4814(((Cci.IMethodReference)this)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 4753, 5032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4856, 4909);

                        f_10186_4856_4908(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 4753, 5032);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 4753, 5032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 4975, 5017);

                        f_10186_4975_5016(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 4753, 5032);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 4555, 5032);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 4473, 5043);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10186_4559_4620(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 4559, 4620);
                    return return_v;
                }


                int
                f_10186_4662_4718(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference
                genericMethodInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericMethodInstanceReference)genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4662, 4718);
                    return 0;
                }


                Microsoft.Cci.ISpecializedMethodReference?
                f_10186_4757_4814(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedMethodReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 4757, 4814);
                    return return_v;
                }


                int
                f_10186_4856_4908(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedMethodReference
                methodReference)
                {
                    this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4856, 4908);
                    return 0;
                }


                int
                f_10186_4975_5016(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference
                methodReference)
                {
                    this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 4975, 5016);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 4473, 5043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 4473, 5043);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 5055, 5167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 5144, 5156);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 5055, 5167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5055, 5167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5055, 5167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 5251, 5258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 5254, 5258);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 5251, 5258);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5251, 5258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5251, 5258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 5324, 5362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 5330, 5360);

                    return f_10186_5337_5359(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 5324, 5362);

                    string?
                    f_10186_5337_5359(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 5337, 5359);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5271, 5373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5271, 5373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.ITypeReference> Cci.IGenericMethodInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 5385, 5616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 5518, 5605);

                return f_10186_5525_5604(f_10186_5525_5575(_underlyingMethod), context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 5385, 5616);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10186_5525_5575(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 5525, 5575);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_10186_5525_5604(Microsoft.Cci.IGenericMethodInstanceReference?
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 5525, 5604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5385, 5616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5385, 5616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.IGenericMethodInstanceReference.GetGenericMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 5628, 5894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 5747, 5883);

                return f_10186_5754_5882(f_10186_5789_5865(f_10186_5789_5839(_underlyingMethod), context), _argListParams);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 5628, 5894);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10186_5789_5839(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 5789, 5839);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10186_5789_5865(Microsoft.Cci.IGenericMethodInstanceReference?
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 5789, 5865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference
                f_10186_5754_5882(Microsoft.Cci.IMethodReference
                underlyingMethod, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                argListParams)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference(underlyingMethod, argListParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 5754, 5882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5628, 5894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5628, 5894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.ISpecializedMethodReference.UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 6004, 6182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6040, 6167);

                    return f_10186_6047_6166(f_10186_6082_6149(f_10186_6082_6128(_underlyingMethod)), _argListParams);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 6004, 6182);

                    Microsoft.Cci.ISpecializedMethodReference?
                    f_10186_6082_6128(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsSpecializedMethodReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 6082, 6128);
                        return return_v;
                    }


                    Microsoft.Cci.IMethodReference
                    f_10186_6082_6149(Microsoft.Cci.ISpecializedMethodReference?
                    this_param)
                    {
                        var return_v = this_param.UnspecializedVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 6082, 6149);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference
                    f_10186_6047_6166(Microsoft.Cci.IMethodReference
                    underlyingMethod, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                    argListParams)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference(underlyingMethod, argListParams);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6047, 6166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 5906, 6193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 5906, 6193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 6205, 7088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6263, 6310);

                var
                result = f_10186_6276_6309()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6324, 6407);

                f_10186_6324_6406(result, f_10186_6339_6376(_underlyingMethod) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Symbols.ISymbolInternal?>(10186, 6339, 6405) ?? (object)_underlyingMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6423, 6466);

                f_10186_6423_6465(
                            result.Builder, " with __arglist( ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6482, 6500);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6516, 6986);
                    foreach (var p in f_10186_6534_6548_I(_argListParams))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 6516, 6986);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6582, 6776) || true) && (first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 6582, 6776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6633, 6647);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 6582, 6776);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 6582, 6776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6729, 6757);

                            f_10186_6729_6756(result.Builder, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 6582, 6776);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6796, 6906) || true) && (f_10186_6800_6815(p))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 6796, 6906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6857, 6887);

                            f_10186_6857_6886(result.Builder, "ref ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 6796, 6906);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 6926, 6971);

                        f_10186_6926_6970(result, f_10186_6941_6969(p, f_10186_6951_6968()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 6516, 6986);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10186, 1, 471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10186, 1, 471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7002, 7029);

                f_10186_7002_7028(
                            result.Builder, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7045, 7077);

                return f_10186_7052_7076(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 6205, 7088);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10186_6276_6309()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6276, 6309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10186_6339_6376(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6339, 6376);
                    return return_v;
                }


                int
                f_10186_6324_6406(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                result, object
                value)
                {
                    Append(result, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6324, 6406);
                    return 0;
                }


                System.Text.StringBuilder
                f_10186_6423_6465(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6423, 6465);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10186_6729_6756(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6729, 6756);
                    return return_v;
                }


                bool
                f_10186_6800_6815(Microsoft.Cci.IParameterTypeInformation
                this_param)
                {
                    var return_v = this_param.IsByReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 6800, 6815);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10186_6857_6886(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6857, 6886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_10186_6951_6968()
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6951, 6968);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10186_6941_6969(Microsoft.Cci.IParameterTypeInformation
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6941, 6969);
                    return return_v;
                }


                int
                f_10186_6926_6970(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                result, Microsoft.Cci.ITypeReference
                value)
                {
                    Append(result, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6926, 6970);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10186_6534_6548_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 6534, 6548);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10186_7002_7028(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7002, 7028);
                    return return_v;
                }


                string
                f_10186_7052_7076(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7052, 7076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 6205, 7088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 6205, 7088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void Append(PooledStringBuilder result, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10186, 7100, 7701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7193, 7227);

                f_10186_7193_7226(!(value is ISymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7336, 7423);

                var
                symbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10186, 7349, 7375) || (((value is ISymbolInternal) && DynAbs.Tracing.TraceSender.Conditional_F2(10186, 7378, 7415)) || DynAbs.Tracing.TraceSender.Conditional_F3(10186, 7418, 7422))) ? f_10186_7378_7415(((ISymbolInternal)value)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7439, 7690) || true) && (symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 7439, 7690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7491, 7580);

                    f_10186_7491_7579(result.Builder, f_10186_7513_7578(symbol, SymbolDisplayFormat.ILVisualizationFormat));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 7439, 7690);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10186, 7439, 7690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7646, 7675);

                    f_10186_7646_7674(result.Builder, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10186, 7439, 7690);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10186, 7100, 7701);

                int
                f_10186_7193_7226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7193, 7226);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10186_7378_7415(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7378, 7415);
                    return return_v;
                }


                string
                f_10186_7513_7578(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7513, 7578);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10186_7491_7579(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7491, 7579);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10186_7646_7674(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 7646, 7674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 7100, 7701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 7100, 7701);
            }
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 7713, 7992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 7927, 7981);

                throw f_10186_7933_7980();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 7713, 7992);

                System.Exception
                f_10186_7933_7980()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 7933, 7980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 7713, 7992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 7713, 7992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10186, 8004, 8277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10186, 8212, 8266);

                throw f_10186_8218_8265();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10186, 8004, 8277);

                System.Exception
                f_10186_8218_8265()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 8218, 8265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10186, 8004, 8277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 8004, 8277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExpandedVarargsMethodReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10186, 546, 8284);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10186, 546, 8284);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10186, 546, 8284);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10186, 546, 8284);

        bool
        f_10186_1066_1104(Microsoft.Cci.IMethodReference
        this_param)
        {
            var return_v = this_param.AcceptsExtraArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 1066, 1104);
            return return_v;
        }


        int
        f_10186_1053_1105(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 1053, 1105);
            return 0;
        }


        bool
        f_10186_1133_1155_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10186, 1133, 1155);
            return return_v;
        }


        int
        f_10186_1120_1156(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10186, 1120, 1156);
            return 0;
        }

    }
}
