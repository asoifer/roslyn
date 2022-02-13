// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class FunctionPointerParameterSymbol : ParameterSymbol
    {
        private readonly FunctionPointerMethodSymbol _containingSymbol;

        public FunctionPointerParameterSymbol(TypeWithAnnotations typeWithAnnotations, RefKind refKind, int ordinal, FunctionPointerMethodSymbol containingSymbol, ImmutableArray<CustomModifier> refCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10632, 545, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 515, 532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1083, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1133, 1169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 775, 817);

                TypeWithAnnotations = typeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 831, 849);

                RefKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 863, 881);

                Ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 895, 932);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 946, 986);

                RefCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10632, 545, 997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 545, 997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 545, 997);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations { get; }

        public override RefKind RefKind { get; }

        public override int Ordinal { get; }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 1219, 1239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1222, 1239);
                    return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 1219, 1239);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 1219, 1239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 1219, 1239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        public override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 1336, 1715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1431, 1524) || true) && (f_10632_1435_1463(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10632, 1431, 1524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1497, 1509);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10632, 1431, 1524);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1540, 1654) || true) && (!(other is FunctionPointerParameterSymbol param))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10632, 1540, 1654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1626, 1639);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10632, 1540, 1654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1670, 1704);

                return f_10632_1677_1703(this, param, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 1336, 1715);

                bool
                f_10632_1435_1463(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 1435, 1463);
                    return return_v;
                }


                bool
                f_10632_1677_1703(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 1677, 1703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 1336, 1715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 1336, 1715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Equals(FunctionPointerParameterSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 1828, 1937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 1831, 1937);
                return f_10632_1831_1844(other) == f_10632_1848_1855() && (DynAbs.Tracing.TraceSender.Expression_True(10632, 1831, 1937) && f_10632_1875_1937(_containingSymbol, other._containingSymbol, compareKind)); DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 1828, 1937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 1828, 1937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 1828, 1937);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10632_1831_1844(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
            this_param)
            {
                var return_v = this_param.Ordinal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 1831, 1844);
                return return_v;
            }


            int
            f_10632_1848_1855()
            {
                var return_v = Ordinal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 1848, 1855);
                return return_v;
            }


            bool
            f_10632_1875_1937(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            other, Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = this_param.Equals(other, compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 1875, 1937);
                return return_v;
            }

        }

        internal bool MethodEqualityChecks(FunctionPointerParameterSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 2065, 2420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 2068, 2420);
                return f_10632_2068_2144(compareKind, f_10632_2121_2128(), f_10632_2130_2143(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10632, 2068, 2334) && ((compareKind & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) != 0
                || (DynAbs.Tracing.TraceSender.Expression_False(10632, 2165, 2333) || f_10632_2275_2293().SequenceEqual(f_10632_2308_2332(other))))
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10632, 2068, 2420) && f_10632_2354_2373().Equals(f_10632_2381_2406(other), compareKind)); DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 2065, 2420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 2065, 2420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 2065, 2420);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.RefKind
            f_10632_2121_2128()
            {
                var return_v = RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2121, 2128);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10632_2130_2143(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
            this_param)
            {
                var return_v = this_param.RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2130, 2143);
                return return_v;
            }


            bool
            f_10632_2068_2144(Microsoft.CodeAnalysis.TypeCompareKind
            compareKind, Microsoft.CodeAnalysis.RefKind
            refKind1, Microsoft.CodeAnalysis.RefKind
            refKind2)
            {
                var return_v = FunctionPointerTypeSymbol.RefKindEquals(compareKind, refKind1, refKind2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2068, 2144);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10632_2275_2293()
            {
                var return_v = RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2275, 2293);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10632_2308_2332(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
            this_param)
            {
                var return_v = this_param.RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2308, 2332);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10632_2354_2373()
            {
                var return_v = TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2354, 2373);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10632_2381_2406(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
            this_param)
            {
                var return_v = this_param.TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2381, 2406);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 2433, 2568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 2491, 2557);

                return f_10632_2498_2556(f_10632_2511_2542(_containingSymbol), f_10632_2544_2551() + 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 2433, 2568);

                int
                f_10632_2511_2542(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2511, 2542);
                    return return_v;
                }


                int
                f_10632_2544_2551()
                {
                    var return_v = Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2544, 2551);
                    return return_v;
                }


                int
                f_10632_2498_2556(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2498, 2556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 2433, 2568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 2433, 2568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int MethodHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 2623, 2745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 2626, 2745);
                return f_10632_2626_2745(f_10632_2639_2658().GetHashCode(), f_10632_2674_2744(f_10632_2674_2730(f_10632_2722_2729()))); DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 2623, 2745);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 2623, 2745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 2623, 2745);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10632_2639_2658()
            {
                var return_v = TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2639, 2658);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10632_2722_2729()
            {
                var return_v = RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 2722, 2729);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10632_2674_2730(Microsoft.CodeAnalysis.RefKind
            refKind)
            {
                var return_v = FunctionPointerTypeSymbol.GetRefKindForHashCode(refKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2674, 2730);
                return return_v;
            }


            int
            f_10632_2674_2744(Microsoft.CodeAnalysis.RefKind
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2674, 2744);
                return return_v;
            }


            int
            f_10632_2626_2745(int
            newKey, int
            currentKey)
            {
                var return_v = Hash.Combine(newKey, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10632, 2626, 2745);
                return return_v;
            }

        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 2809, 2842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 2812, 2842);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 2809, 2842);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 2809, 2842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 2809, 2842);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 2927, 2967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 2930, 2967);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 2927, 2967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 2927, 2967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 2927, 2967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3009, 3017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3012, 3017);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3009, 3017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3009, 3017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3009, 3017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3058, 3066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3061, 3066);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3058, 3066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3058, 3066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3058, 3066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3119, 3126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3122, 3126);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3119, 3126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3119, 3126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3119, 3126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData? MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3212, 3219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3215, 3219);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3212, 3219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3212, 3219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3212, 3219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3272, 3280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3275, 3280);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3272, 3280);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3272, 3280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3272, 3280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3327, 3351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3330, 3351);
                    return f_10632_3330_3337() == RefKind.In; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3327, 3351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3327, 3351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3327, 3351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3399, 3424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3402, 3424);
                    return f_10632_3402_3409() == RefKind.Out; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3399, 3424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3399, 3424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3399, 3424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue? ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3497, 3504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3500, 3504);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3497, 3504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3497, 3504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3497, 3504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3558, 3566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3561, 3566);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3558, 3566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3558, 3566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3558, 3566);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3619, 3627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3622, 3627);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3619, 3627);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3619, 3627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3619, 3627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3678, 3686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3681, 3686);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3678, 3686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3678, 3686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3678, 3686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3739, 3747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3742, 3747);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3739, 3747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3739, 3747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3739, 3747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3800, 3808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3803, 3808);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3800, 3808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3800, 3808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3800, 3808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3885, 3916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3888, 3916);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3885, 3916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3885, 3916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3885, 3916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10632, 3996, 4029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10632, 3999, 4029);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10632, 3996, 4029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10632, 3996, 4029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 3996, 4029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FunctionPointerParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10632, 383, 4037);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10632, 383, 4037);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10632, 383, 4037);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10632, 383, 4037);

        Microsoft.CodeAnalysis.RefKind
        f_10632_3330_3337()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 3330, 3337);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10632_3402_3409()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10632, 3402, 3409);
            return return_v;
        }

    }
}
