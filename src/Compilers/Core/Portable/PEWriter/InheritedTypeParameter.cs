// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal class InheritedTypeParameter : IGenericTypeParameter
    {
        private readonly ushort _index;

        private readonly ITypeDefinition _inheritingType;

        private readonly IGenericTypeParameter _parentParameter;

        internal InheritedTypeParameter(ushort index, ITypeDefinition inheritingType, IGenericTypeParameter parentParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(491, 660, 923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 516, 522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 566, 581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 631, 647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 801, 816);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 830, 863);

                _inheritingType = inheritingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 877, 912);

                _parentParameter = parentParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(491, 660, 923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 660, 923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 660, 923);
            }
        }

        public ITypeDefinition DefiningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1044, 1075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1050, 1073);

                    return _inheritingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1044, 1075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 984, 1086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 984, 1086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<TypeReferenceWithAttributes> GetConstraints(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1165, 1332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1273, 1321);

                return f_491_1280_1320(_parentParameter, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1165, 1332);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_491_1280_1320(Microsoft.Cci.IGenericTypeParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetConstraints(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(491, 1280, 1320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 1165, 1332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 1165, 1332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MustBeReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1400, 1452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1406, 1450);

                    return f_491_1413_1449(_parentParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1400, 1452);

                    bool
                    f_491_1413_1449(Microsoft.Cci.IGenericTypeParameter
                    this_param)
                    {
                        var return_v = this_param.MustBeReferenceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1413, 1449);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 1344, 1463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 1344, 1463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MustBeValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1527, 1575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1533, 1573);

                    return f_491_1540_1572(_parentParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1527, 1575);

                    bool
                    f_491_1540_1572(Microsoft.Cci.IGenericTypeParameter
                    this_param)
                    {
                        var return_v = this_param.MustBeValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1540, 1572);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 1475, 1586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 1475, 1586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MustHaveDefaultConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1661, 1720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1667, 1718);

                    return f_491_1674_1717(_parentParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1661, 1720);

                    bool
                    f_491_1674_1717(Microsoft.Cci.IGenericTypeParameter
                    this_param)
                    {
                        var return_v = this_param.MustHaveDefaultConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1674, 1717);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 1598, 1731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 1598, 1731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeParameterVariance Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 1805, 1941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 1811, 1939);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(491, 1818, 1875) || ((f_491_1818_1845(_inheritingType) || (DynAbs.Tracing.TraceSender.Expression_False(491, 1818, 1875) || f_491_1849_1875(_inheritingType)) && DynAbs.Tracing.TraceSender.Conditional_F2(491, 1878, 1903)) || DynAbs.Tracing.TraceSender.Conditional_F3(491, 1906, 1938))) ? f_491_1878_1903(_parentParameter) : TypeParameterVariance.NonVariant;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 1805, 1941);

                    bool
                    f_491_1818_1845(Microsoft.Cci.ITypeDefinition
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1818, 1845);
                        return return_v;
                    }


                    bool
                    f_491_1849_1875(Microsoft.Cci.ITypeDefinition
                    this_param)
                    {
                        var return_v = this_param.IsDelegate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1849, 1875);
                        return return_v;
                    }


                    Microsoft.Cci.TypeParameterVariance
                    f_491_1878_1903(Microsoft.Cci.IGenericTypeParameter
                    this_param)
                    {
                        var return_v = this_param.Variance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 1878, 1903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 1743, 1952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 1743, 1952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2077, 2094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2083, 2092);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2077, 2094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2029, 2105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2029, 2105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2176, 2197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2182, 2195);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2176, 2197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2117, 2208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2117, 2208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2263, 2284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2269, 2282);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2263, 2284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2220, 2295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2220, 2295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IArrayTypeReference? AsArrayTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2380, 2466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2416, 2451);

                    return this as IArrayTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2380, 2466);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2307, 2477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2307, 2477);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericMethodParameter? AsGenericMethodParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2570, 2660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2606, 2645);

                    return this as IGenericMethodParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2570, 2660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2489, 2671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2489, 2671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericMethodParameterReference? AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2782, 2881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 2818, 2866);

                    return this as IGenericMethodParameterReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2782, 2881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2683, 2892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2683, 2892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericTypeInstanceReference? AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 2997, 3093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3033, 3078);

                    return this as IGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 2997, 3093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 2904, 3104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 2904, 3104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericTypeParameter? AsGenericTypeParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 3193, 3281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3229, 3266);

                    return this as IGenericTypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 3193, 3281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 3116, 3292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 3116, 3292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericTypeParameterReference? AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 3399, 3496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3435, 3481);

                    return this as IGenericTypeParameterReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 3399, 3496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 3304, 3507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 3304, 3507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public INamespaceTypeDefinition? AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 3519, 3674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3623, 3663);

                return this as INamespaceTypeDefinition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 3519, 3674);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 3519, 3674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 3519, 3674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public INamespaceTypeReference? AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 3767, 3857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3803, 3842);

                    return this as INamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 3767, 3857);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 3686, 3868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 3686, 3868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public INestedTypeDefinition? AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 3880, 4026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 3978, 4015);

                return this as INestedTypeDefinition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 3880, 4026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 3880, 4026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 3880, 4026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public INestedTypeReference? AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4113, 4200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 4149, 4185);

                    return this as INestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4113, 4200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4038, 4211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4038, 4211);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISpecializedNestedTypeReference? AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4320, 4418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 4356, 4403);

                    return this as ISpecializedNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4320, 4418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4223, 4429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4223, 4429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IModifiedTypeReference? AsModifiedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4520, 4609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 4556, 4594);

                    return this as IModifiedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4520, 4609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4441, 4620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4441, 4620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IPointerTypeReference? AsPointerTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4709, 4797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 4745, 4782);

                    return this as IPointerTypeReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4709, 4797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4632, 4808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4632, 4808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeDefinition? AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4820, 4948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 4906, 4937);

                return this as ITypeDefinition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4820, 4948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4820, 4948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4820, 4948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IDefinition? AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 4960, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5038, 5065);

                return this as IDefinition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 4960, 5076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 4960, 5076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 4960, 5076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5221, 5228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5224, 5228);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5221, 5228);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5221, 5228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5221, 5228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5241, 5395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5337, 5384);

                return f_491_5344_5383(_parentParameter, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5241, 5395);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_491_5344_5383(Microsoft.Cci.IGenericTypeParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(491, 5344, 5383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5241, 5395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5241, 5395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5407, 5474);
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5407, 5474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5407, 5474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5407, 5474);
            }
        }

        public TypeDefinitionHandle TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5610, 5698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5646, 5683);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5610, 5698);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5550, 5709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5550, 5709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAlias
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5765, 5786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5771, 5784);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5765, 5786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5721, 5797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5721, 5797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5857, 5878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5863, 5876);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5857, 5878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5809, 5889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5809, 5889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeDefinition GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 5901, 6033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 5985, 6022);

                throw f_491_5991_6021();
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 5901, 6033);

                System.Exception
                f_491_5991_6021()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 5991, 6021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 5901, 6033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 5901, 6033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PrimitiveTypeCode TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6103, 6149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6109, 6147);

                    return PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6103, 6149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6045, 6160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6045, 6160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6285, 6307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6291, 6305);

                    return _index;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6285, 6307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6241, 6318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6241, 6318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6436, 6473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6442, 6471);

                    return f_491_6449_6470(_parentParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6436, 6473);

                    string?
                    f_491_6449_6470(Microsoft.Cci.IGenericTypeParameter
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 6449, 6470);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6392, 6484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6392, 6484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeReference IGenericTypeParameterReference.DefiningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6659, 6690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6665, 6688);

                    return _inheritingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6659, 6690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6576, 6701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6576, 6701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6829, 6850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6835, 6848);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6829, 6850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6782, 6861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6782, 6861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNested
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 6940, 6985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 6946, 6983);

                    throw f_491_6952_6982();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 6940, 6985);

                    System.Exception
                    f_491_6952_6982()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 6952, 6982);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 6895, 6996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 6895, 6996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSpecializedNested
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7064, 7109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 7070, 7107);

                    throw f_491_7076_7106();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7064, 7109);

                    System.Exception
                    f_491_7076_7106()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 7076, 7106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7008, 7120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7008, 7120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeReference UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7199, 7244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 7205, 7242);

                    throw f_491_7211_7241();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7199, 7244);

                    System.Exception
                    f_491_7211_7241()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 7211, 7241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7132, 7255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7132, 7255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7328, 7373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 7334, 7371);

                    throw f_491_7340_7370();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7328, 7373);

                    System.Exception
                    f_491_7340_7370()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 7340, 7370);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7267, 7384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7267, 7384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGenericTypeInstance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7454, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 7460, 7497);

                    throw f_491_7466_7496();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7454, 7499);

                    System.Exception
                    f_491_7466_7496()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 7466, 7496);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7396, 7510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7396, 7510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7522, 7802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 7737, 7791);

                throw f_491_7743_7790();
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7522, 7802);

                System.Exception
                f_491_7743_7790()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 7743, 7790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7522, 7802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7522, 7802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(491, 7814, 8087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(491, 8022, 8076);

                throw f_491_8028_8075();
                DynAbs.Tracing.TraceSender.TraceExitMethod(491, 7814, 8087);

                System.Exception
                f_491_8028_8075()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(491, 8028, 8075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(491, 7814, 8087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 7814, 8087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InheritedTypeParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(491, 414, 8094);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(491, 414, 8094);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(491, 414, 8094);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(491, 414, 8094);
    }
}
