// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ConversionSignatureComparer : IEqualityComparer<SourceUserDefinedConversionSymbol>
    {
        private static readonly ConversionSignatureComparer s_comparer;

        public static ConversionSignatureComparer Comparer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10097, 652, 721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 688, 706);

                    return s_comparer;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10097, 652, 721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10097, 577, 732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10097, 577, 732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConversionSignatureComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10097, 744, 803);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10097, 744, 803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10097, 744, 803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10097, 744, 803);
            }
        }

        public bool Equals(SourceUserDefinedConversionSymbol member1, SourceUserDefinedConversionSymbol member2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10097, 815, 2174);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 944, 1042) || true) && (f_10097_948_981(member1, member2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10097, 944, 1042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1015, 1027);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10097, 944, 1042);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1058, 1188) || true) && (f_10097_1062_1092(member1, null) || (DynAbs.Tracing.TraceSender.Expression_False(10097, 1062, 1126) || f_10097_1096_1126(member2, null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10097, 1058, 1188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1160, 1173);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10097, 1058, 1188);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1654, 1778) || true) && (f_10097_1658_1680(member1) != 1 || (DynAbs.Tracing.TraceSender.Expression_False(10097, 1658, 1716) || f_10097_1689_1711(member2) != 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10097, 1654, 1778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1750, 1763);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10097, 1654, 1778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 1794, 2163);

                return f_10097_1801_1949(f_10097_1801_1819(member1), f_10097_1827_1845(member2), TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes) && (DynAbs.Tracing.TraceSender.Expression_True(10097, 1801, 2162) && f_10097_1970_2007(member1)[0].Equals(f_10097_2018_2055(member2)[0], TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10097, 815, 2174);

                bool
                f_10097_948_981(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 948, 981);
                    return return_v;
                }


                bool
                f_10097_1062_1092(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 1062, 1092);
                    return return_v;
                }


                bool
                f_10097_1096_1126(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 1096, 1126);
                    return return_v;
                }


                int
                f_10097_1658_1680(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 1658, 1680);
                    return return_v;
                }


                int
                f_10097_1689_1711(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 1689, 1711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10097_1801_1819(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 1801, 1819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10097_1827_1845(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 1827, 1845);
                    return return_v;
                }


                bool
                f_10097_1801_1949(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 1801, 1949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10097_1970_2007(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 1970, 2007);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10097_2018_2055(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 2018, 2055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10097, 815, 2174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10097, 815, 2174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(SourceUserDefinedConversionSymbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10097, 2186, 2685);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2275, 2359) || true) && ((object)member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10097, 2275, 2359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2335, 2344);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10097, 2275, 2359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2375, 2388);

                int
                hash = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2402, 2461);

                hash = f_10097_2409_2460(f_10097_2422_2453(f_10097_2422_2439(member)), hash);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2475, 2566) || true) && (f_10097_2479_2500(member) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10097, 2475, 2566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2539, 2551);

                    return hash;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10097, 2475, 2566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2580, 2648);

                hash = f_10097_2587_2647(f_10097_2600_2640(f_10097_2600_2626(member, 0)), hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 2662, 2674);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10097, 2186, 2685);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10097_2422_2439(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 2422, 2439);
                    return return_v;
                }


                int
                f_10097_2422_2453(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 2422, 2453);
                    return return_v;
                }


                int
                f_10097_2409_2460(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 2409, 2460);
                    return return_v;
                }


                int
                f_10097_2479_2500(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10097, 2479, 2500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10097_2600_2626(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 2600, 2626);
                    return return_v;
                }


                int
                f_10097_2600_2640(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 2600, 2640);
                    return return_v;
                }


                int
                f_10097_2587_2647(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 2587, 2647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10097, 2186, 2685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10097, 2186, 2685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConversionSignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10097, 347, 2692);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10097, 520, 566);
            s_comparer = f_10097_533_566(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10097, 347, 2692);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10097, 347, 2692);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10097, 347, 2692);

        static Microsoft.CodeAnalysis.CSharp.Symbols.ConversionSignatureComparer
        f_10097_533_566()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConversionSignatureComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10097, 533, 566);
            return return_v;
        }

    }
}
