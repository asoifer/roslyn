// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.RuntimeMembers
{
    internal abstract class SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
            where MethodSymbol : class
            where FieldSymbol : class
            where PropertySymbol : class
            where TypeSymbol : class
            where ParameterSymbol : class
    {        /// <summary>
             /// Returns true if signature matches signature of the field.
             /// Signature should be in format described in MemberDescriptor.
             /// </summary>
        public bool MatchFieldSignature(FieldSymbol field, ImmutableArray<byte> signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(30, 1052, 1400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1159, 1176);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1221, 1291);

                bool
                result = f_30_1235_1290(this, f_30_1245_1264(this, field), signature, ref position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1307, 1361);

                f_30_1307_1360(!result || (DynAbs.Tracing.TraceSender.Expression_False(30, 1320, 1359) || position == signature.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1375, 1389);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(30, 1052, 1400);

                TypeSymbol
                f_30_1245_1264(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, FieldSymbol
                field)
                {
                    var return_v = this_param.GetFieldType(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 1245, 1264);
                    return return_v;
                }


                bool
                f_30_1235_1290(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 1235, 1290);
                    return return_v;
                }


                int
                f_30_1307_1360(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 1307, 1360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 1052, 1400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 1052, 1400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns true if signature matches signature of the property.
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        public bool MatchPropertySignature(PropertySymbol property, ImmutableArray<byte> signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(30, 1607, 2809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1723, 1740);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1796, 1835);

                int
                paramCount = signature[position++]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1894, 1963);

                ImmutableArray<ParameterSymbol>
                parameters = f_30_1939_1962(this, property)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 1979, 2076) || true) && (paramCount != parameters.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 1979, 2076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2048, 2061);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 1979, 2076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2092, 2140);

                bool
                isByRef = f_30_2107_2139(signature, ref position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2154, 2256) || true) && (f_30_2158_2183(this, property) != isByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 2154, 2256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2228, 2241);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 2154, 2256);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2310, 2438) || true) && (!f_30_2315_2376(this, f_30_2325_2350(this, property), signature, ref position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 2310, 2438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2410, 2423);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 2310, 2438);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2487, 2713);
                    foreach (ParameterSymbol parameter in f_30_2525_2535_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 2487, 2713);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2569, 2698) || true) && (!f_30_2574_2624(this, parameter, signature, ref position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 2569, 2698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2666, 2679);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(30, 2569, 2698);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 2487, 2713);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(30, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(30, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2729, 2772);

                f_30_2729_2771(position == signature.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 2786, 2798);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(30, 1607, 2809);

                System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                f_30_1939_1962(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, PropertySymbol
                property)
                {
                    var return_v = this_param.GetParameters(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 1939, 1962);
                    return return_v;
                }


                bool
                f_30_2107_2139(System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = IsByRef(signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2107, 2139);
                    return return_v;
                }


                bool
                f_30_2158_2183(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, PropertySymbol
                property)
                {
                    var return_v = this_param.IsByRefProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2158, 2183);
                    return return_v;
                }


                TypeSymbol
                f_30_2325_2350(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, PropertySymbol
                property)
                {
                    var return_v = this_param.GetPropertyType(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2325, 2350);
                    return return_v;
                }


                bool
                f_30_2315_2376(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2315, 2376);
                    return return_v;
                }


                bool
                f_30_2574_2624(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, ParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchParameter(parameter, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2574, 2624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                f_30_2525_2535_I(System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2525, 2535);
                    return return_v;
                }


                int
                f_30_2729_2771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 2729, 2771);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 1607, 2809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 1607, 2809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns true if signature matches signature of the method.
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        public bool MatchMethodSignature(MethodSymbol method, ImmutableArray<byte> signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(30, 3014, 4200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3124, 3141);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3197, 3236);

                int
                paramCount = signature[position++]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3295, 3362);

                ImmutableArray<ParameterSymbol>
                parameters = f_30_3340_3361(this, method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3378, 3475) || true) && (paramCount != parameters.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 3378, 3475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3447, 3460);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 3378, 3475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3491, 3539);

                bool
                isByRef = f_30_3506_3538(signature, ref position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3555, 3653) || true) && (f_30_3559_3580(this, method) != isByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 3555, 3653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3625, 3638);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 3555, 3653);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3705, 3829) || true) && (!f_30_3710_3767(this, f_30_3720_3741(this, method), signature, ref position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 3705, 3829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3801, 3814);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 3705, 3829);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3878, 4104);
                    foreach (ParameterSymbol parameter in f_30_3916_3926_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 3878, 4104);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 3960, 4089) || true) && (!f_30_3965_4015(this, parameter, signature, ref position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 3960, 4089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4057, 4070);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(30, 3960, 4089);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 3878, 4104);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(30, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(30, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4120, 4163);

                f_30_4120_4162(position == signature.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4177, 4189);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(30, 3014, 4200);

                System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                f_30_3340_3361(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, MethodSymbol
                method)
                {
                    var return_v = this_param.GetParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3340, 3361);
                    return return_v;
                }


                bool
                f_30_3506_3538(System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = IsByRef(signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3506, 3538);
                    return return_v;
                }


                bool
                f_30_3559_3580(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, MethodSymbol
                method)
                {
                    var return_v = this_param.IsByRefMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3559, 3580);
                    return return_v;
                }


                TypeSymbol
                f_30_3720_3741(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, MethodSymbol
                method)
                {
                    var return_v = this_param.GetReturnType(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3720, 3741);
                    return return_v;
                }


                bool
                f_30_3710_3767(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3710, 3767);
                    return return_v;
                }


                bool
                f_30_3965_4015(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, ParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchParameter(parameter, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3965, 4015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                f_30_3916_3926_I(System.Collections.Immutable.ImmutableArray<ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 3916, 3926);
                    return return_v;
                }


                int
                f_30_4120_4162(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 4120, 4162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 3014, 4200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 3014, 4200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MatchParameter(ParameterSymbol parameter, ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(30, 4212, 4599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4341, 4389);

                bool
                isByRef = f_30_4356_4388(signature, ref position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4405, 4505) || true) && (f_30_4409_4432(this, parameter) != isByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 4405, 4505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4477, 4490);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 4405, 4505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4521, 4588);

                return f_30_4528_4587(this, f_30_4538_4561(this, parameter), signature, ref position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(30, 4212, 4599);

                bool
                f_30_4356_4388(System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = IsByRef(signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 4356, 4388);
                    return return_v;
                }


                bool
                f_30_4409_4432(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, ParameterSymbol
                parameter)
                {
                    var return_v = this_param.IsByRefParam(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 4409, 4432);
                    return return_v;
                }


                TypeSymbol
                f_30_4538_4561(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, ParameterSymbol
                parameter)
                {
                    var return_v = this_param.GetParamType(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 4538, 4561);
                    return return_v;
                }


                bool
                f_30_4528_4587(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 4528, 4587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 4212, 4599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 4212, 4599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsByRef(ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(30, 4611, 5022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4713, 4781);

                SignatureTypeCode
                typeCode = (SignatureTypeCode)signature[position]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4797, 5011) || true) && (typeCode == SignatureTypeCode.ByReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 4797, 5011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4876, 4887);

                    position++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4905, 4917);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 4797, 5011);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 4797, 5011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4983, 4996);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 4797, 5011);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(30, 4611, 5022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 4611, 5022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 4611, 5022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        /// <summary>
        /// Does pretty much the same thing as MetadataDecoder.DecodeType only instead of 
        /// producing a type symbol it compares encoded type to the target.
        /// 
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        private bool MatchType(TypeSymbol? type, ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(30, 5340, 8138);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 5455, 5533) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5455, 5533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 5505, 5518);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5455, 5533);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 5549, 5567);

                int
                paramPosition
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 5613, 5683);

                SignatureTypeCode
                typeCode = (SignatureTypeCode)signature[position++]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 5735, 8127);

                switch (typeCode)
                {

                    case SignatureTypeCode.TypeHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6147, 6204);

                        short
                        expectedType = f_30_6168_6203(signature, ref position)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6226, 6271);

                        return f_30_6233_6270(this, type, expectedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6342, 6496) || true) && (!f_30_6347_6410(this, f_30_6357_6384(this, type), signature, ref position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 6342, 6496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6460, 6473);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(30, 6342, 6496);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6520, 6566);

                        int
                        countOfDimensions = signature[position++]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6590, 6637);

                        return f_30_6597_6636(this, type, countOfDimensions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.SZArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6710, 6781);

                        return f_30_6717_6780(this, f_30_6727_6754(this, type), signature, ref position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 6854, 6920);

                        return f_30_6861_6919(this, f_30_6871_6893(this, type), signature, ref position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.GenericTypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7006, 7044);

                        paramPosition = signature[position++];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7066, 7113);

                        return f_30_7073_7112(this, type, paramPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.GenericMethodParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7201, 7239);

                        paramPosition = signature[position++];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7261, 7314);

                        return f_30_7268_7313(this, type, paramPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    case SignatureTypeCode.GenericTypeInstance:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7399, 7556) || true) && (!f_30_7404_7470(this, f_30_7414_7444(this, type), signature, ref position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 7399, 7556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7520, 7533);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(30, 7399, 7556);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7580, 7622);

                        int
                        argumentCount = signature[position++]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7655, 7672);

                            for (int
        argumentIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7646, 7975) || true) && (argumentIndex < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7705, 7720)
        , argumentIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(30, 7646, 7975))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 7646, 7975);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7770, 7952) || true) && (!f_30_7775_7854(this, f_30_7785_7828(this, type, argumentIndex), signature, ref position))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 7770, 7952);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7912, 7925);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 7770, 7952);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(30, 1, 330);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(30, 1, 330);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 7999, 8011);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 5735, 8127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8061, 8112);

                        throw f_30_8067_8111(typeCode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(30, 5735, 8127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(30, 5340, 8138);

                short
                f_30_6168_6203(System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = ReadTypeId(signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6168, 6203);
                    return return_v;
                }


                bool
                f_30_6233_6270(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, short
                typeId)
                {
                    var return_v = this_param.MatchTypeToTypeId(type, (int)typeId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6233, 6270);
                    return return_v;
                }


                TypeSymbol?
                f_30_6357_6384(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetMDArrayElementType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6357, 6384);
                    return return_v;
                }


                bool
                f_30_6347_6410(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol?
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6347, 6410);
                    return return_v;
                }


                bool
                f_30_6597_6636(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, int
                countOfDimensions)
                {
                    var return_v = this_param.MatchArrayRank(type, countOfDimensions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6597, 6636);
                    return return_v;
                }


                TypeSymbol?
                f_30_6727_6754(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetSZArrayElementType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6727, 6754);
                    return return_v;
                }


                bool
                f_30_6717_6780(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol?
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6717, 6780);
                    return return_v;
                }


                TypeSymbol?
                f_30_6871_6893(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetPointedToType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6871, 6893);
                    return return_v;
                }


                bool
                f_30_6861_6919(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol?
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 6861, 6919);
                    return return_v;
                }


                bool
                f_30_7073_7112(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, int
                paramPosition)
                {
                    var return_v = this_param.IsGenericTypeParam(type, paramPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7073, 7112);
                    return return_v;
                }


                bool
                f_30_7268_7313(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, int
                paramPosition)
                {
                    var return_v = this_param.IsGenericMethodTypeParam(type, paramPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7268, 7313);
                    return return_v;
                }


                TypeSymbol?
                f_30_7414_7444(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetGenericTypeDefinition(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7414, 7444);
                    return return_v;
                }


                bool
                f_30_7404_7470(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol?
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7404, 7470);
                    return return_v;
                }


                TypeSymbol?
                f_30_7785_7828(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol
                type, int
                argumentIndex)
                {
                    var return_v = this_param.GetGenericTypeArgument(type, argumentIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7785, 7828);
                    return return_v;
                }


                bool
                f_30_7775_7854(Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
                this_param, TypeSymbol?
                type, System.Collections.Immutable.ImmutableArray<byte>
                signature, ref int
                position)
                {
                    var return_v = this_param.MatchType(type, signature, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 7775, 7854);
                    return return_v;
                }


                System.Exception
                f_30_8067_8111(System.Reflection.Metadata.SignatureTypeCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(30, 8067, 8111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 5340, 8138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 5340, 8138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static short ReadTypeId(ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(30, 8347, 8762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8453, 8491);

                var
                firstByte = signature[position++]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8505, 8751) || true) && (firstByte == (byte)WellKnownType.ExtSentinel)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 8505, 8751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8587, 8653);

                    return (short)(signature[position++] + WellKnownType.ExtSentinel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 8505, 8751);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 8505, 8751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8719, 8736);

                    return firstByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 8505, 8751);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(30, 8347, 8762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 8347, 8762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 8347, 8762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TypeSymbol? GetGenericTypeArgument(TypeSymbol type, int argumentIndex);

        protected abstract TypeSymbol? GetGenericTypeDefinition(TypeSymbol type);

        protected abstract bool IsGenericMethodTypeParam(TypeSymbol type, int paramPosition);

        protected abstract bool IsGenericTypeParam(TypeSymbol type, int paramPosition);

        protected abstract TypeSymbol? GetPointedToType(TypeSymbol type);

        protected abstract TypeSymbol? GetSZArrayElementType(TypeSymbol type);

        protected abstract bool MatchArrayRank(TypeSymbol type, int countOfDimensions);

        protected abstract TypeSymbol? GetMDArrayElementType(TypeSymbol type);

        protected abstract bool MatchTypeToTypeId(TypeSymbol type, int typeId);

        protected abstract TypeSymbol GetReturnType(MethodSymbol method);

        protected abstract ImmutableArray<ParameterSymbol> GetParameters(MethodSymbol method);

        protected abstract TypeSymbol GetPropertyType(PropertySymbol property);

        protected abstract ImmutableArray<ParameterSymbol> GetParameters(PropertySymbol property);

        protected abstract TypeSymbol GetParamType(ParameterSymbol parameter);

        protected abstract bool IsByRefParam(ParameterSymbol parameter);

        protected abstract bool IsByRefMethod(MethodSymbol method);

        protected abstract bool IsByRefProperty(PropertySymbol property);

        protected abstract TypeSymbol GetFieldType(FieldSymbol field);

        public SignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(30, 548, 10986);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(30, 548, 10986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 548, 10986);
        }


        static SignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(30, 548, 10986);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(30, 548, 10986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 548, 10986);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(30, 548, 10986);
    }
}
