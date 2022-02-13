// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct BinaryOperatorSignature : IEquatable<BinaryOperatorSignature>
    {

        public static BinaryOperatorSignature Error;

        public readonly TypeSymbol LeftType;

        public readonly TypeSymbol RightType;

        public readonly TypeSymbol ReturnType;

        public readonly MethodSymbol Method;

        public readonly BinaryOperatorKind Kind;

        public int? Priority;

        public BinaryOperatorSignature(BinaryOperatorKind kind, TypeSymbol leftType, TypeSymbol rightType, TypeSymbol returnType, MethodSymbol method = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10855, 1165, 1560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1339, 1356);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1370, 1395);

                this.LeftType = leftType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1409, 1436);

                this.RightType = rightType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1450, 1479);

                this.ReturnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1493, 1514);

                this.Method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1528, 1549);

                this.Priority = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10855, 1165, 1560);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 1165, 1560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 1165, 1560);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 1572, 1815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1630, 1804);

                return $"kind: {this.Kind} leftType: {this.LeftType} leftRefKind: {this.LeftRefKind} rightType: {this.RightType} rightRefKind: {this.RightRefKind} return: {this.ReturnType}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 1572, 1815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 1572, 1815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 1572, 1815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(BinaryOperatorSignature other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 1827, 2332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 1901, 2321);

                return
                                this.Kind == other.Kind && (DynAbs.Tracing.TraceSender.Expression_True(10855, 1925, 2054) && f_10855_1969_2054(this.LeftType, other.LeftType, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10855, 1925, 2162) && f_10855_2075_2162(this.RightType, other.RightType, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10855, 1925, 2272) && f_10855_2183_2272(this.ReturnType, other.ReturnType, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10855, 1925, 2320) && this.Method == other.Method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 1827, 2332);

                bool
                f_10855_1969_2054(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 1969, 2054);
                    return return_v;
                }


                bool
                f_10855_2075_2162(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 2075, 2162);
                    return return_v;
                }


                bool
                f_10855_2183_2272(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 2183, 2272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 1827, 2332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 1827, 2332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(BinaryOperatorSignature x, BinaryOperatorSignature y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10855, 2344, 2483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 2453, 2472);

                return x.Equals(y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10855, 2344, 2483);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 2344, 2483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 2344, 2483);
            }
        }

        public static bool operator !=(BinaryOperatorSignature x, BinaryOperatorSignature y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10855, 2495, 2635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 2604, 2624);

                return !x.Equals(y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10855, 2495, 2635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 2495, 2635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 2495, 2635);
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 2647, 2800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 2711, 2789);

                return obj is BinaryOperatorSignature && (DynAbs.Tracing.TraceSender.Expression_True(10855, 2718, 2788) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 2647, 2800);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 2647, 2800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 2647, 2800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 2812, 3055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 2870, 3044);

                return f_10855_2877_3043(ReturnType, f_10855_2922_3042(LeftType, f_10855_2965_3041(RightType, f_10855_3009_3040(Method, Kind))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 2812, 3055);

                int
                f_10855_3009_3040(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                newKeyPart, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 3009, 3040);
                    return return_v;
                }


                int
                f_10855_2965_3041(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 2965, 3041);
                    return return_v;
                }


                int
                f_10855_2922_3042(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 2922, 3042);
                    return return_v;
                }


                int
                f_10855_2877_3043(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 2877, 3043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 2812, 3055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 2812, 3055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RefKind LeftRefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 3118, 3594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3154, 3539) || true) && ((object)Method != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10855, 3154, 3539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3222, 3263);

                        f_10855_3222_3262(f_10855_3235_3256(Method) == 2);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3287, 3520) || true) && (f_10855_3291_3333_M(!Method.ParameterRefKinds.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10855, 3287, 3520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3383, 3434);

                            f_10855_3383_3433(Method.ParameterRefKinds.Length == 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3462, 3497);

                            return f_10855_3469_3493(Method)[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10855, 3287, 3520);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10855, 3154, 3539);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3559, 3579);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 3118, 3594);

                    int
                    f_10855_3235_3256(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 3235, 3256);
                        return return_v;
                    }


                    int
                    f_10855_3222_3262(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 3222, 3262);
                        return 0;
                    }


                    bool
                    f_10855_3291_3333_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 3291, 3333);
                        return return_v;
                    }


                    int
                    f_10855_3383_3433(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 3383, 3433);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10855_3469_3493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterRefKinds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 3469, 3493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 3067, 3605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 3067, 3605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RefKind RightRefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10855, 3669, 4145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3705, 4090) || true) && ((object)Method != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10855, 3705, 4090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3773, 3814);

                        f_10855_3773_3813(f_10855_3786_3807(Method) == 2);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3838, 4071) || true) && (f_10855_3842_3884_M(!Method.ParameterRefKinds.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10855, 3838, 4071);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 3934, 3985);

                            f_10855_3934_3984(Method.ParameterRefKinds.Length == 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 4013, 4048);

                            return f_10855_4020_4044(Method)[1];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10855, 3838, 4071);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10855, 3705, 4090);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 4110, 4130);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10855, 3669, 4145);

                    int
                    f_10855_3786_3807(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 3786, 3807);
                        return return_v;
                    }


                    int
                    f_10855_3773_3813(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 3773, 3813);
                        return 0;
                    }


                    bool
                    f_10855_3842_3884_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 3842, 3884);
                        return return_v;
                    }


                    int
                    f_10855_3934_3984(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10855, 3934, 3984);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10855_4020_4044(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterRefKinds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10855, 4020, 4044);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10855, 3617, 4156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 3617, 4156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static BinaryOperatorSignature()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10855, 392, 4163);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10855, 524, 564);
            Error = default(BinaryOperatorSignature); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10855, 392, 4163);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10855, 392, 4163);
        }
    }
}
