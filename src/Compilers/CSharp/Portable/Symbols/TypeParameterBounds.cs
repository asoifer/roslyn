// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class TypeParameterBounds
    {
        public static readonly TypeParameterBounds Unset;

        public TypeParameterBounds(
                    ImmutableArray<TypeWithAnnotations> constraintTypes,
                    ImmutableArray<NamedTypeSymbol> interfaces,
                    NamedTypeSymbol effectiveBaseClass,
                    TypeSymbol deducedBaseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10171, 944, 1644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 2555, 2573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 3874, 3889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1209, 1250);

                f_10171_1209_1249(f_10171_1222_1248_M(!constraintTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1264, 1300);

                f_10171_1264_1299(f_10171_1277_1298_M(!interfaces.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1314, 1363);

                f_10171_1314_1362((object)effectiveBaseClass != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1377, 1423);

                f_10171_1377_1422((object)deducedBaseType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1439, 1478);

                this.ConstraintTypes = constraintTypes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1492, 1521);

                this.Interfaces = interfaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1535, 1580);

                this.EffectiveBaseClass = effectiveBaseClass;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1594, 1633);

                this.DeducedBaseType = deducedBaseType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10171, 944, 1644);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10171, 944, 1644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10171, 944, 1644);
            }
        }

        private TypeParameterBounds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10171, 1656, 1786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 2555, 2573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 3874, 3889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1710, 1737);

                EffectiveBaseClass = null!;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 1751, 1775);

                DeducedBaseType = null!;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10171, 1656, 1786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10171, 1656, 1786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10171, 1656, 1786);
            }
        }

        public readonly ImmutableArray<TypeWithAnnotations> ConstraintTypes;

        public readonly ImmutableArray<NamedTypeSymbol> Interfaces;

        public readonly NamedTypeSymbol EffectiveBaseClass;

        public readonly TypeSymbol DeducedBaseType;

        static TypeParameterBounds()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10171, 684, 3897);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 785, 818);
            Unset = f_10171_793_818(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10171, 684, 3897);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10171, 684, 3897);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10171, 684, 3897);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
        f_10171_793_818()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10171, 793, 818);
            return return_v;
        }


        bool
        f_10171_1222_1248_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10171, 1222, 1248);
            return return_v;
        }


        int
        f_10171_1209_1249(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10171, 1209, 1249);
            return 0;
        }


        bool
        f_10171_1277_1298_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10171, 1277, 1298);
            return return_v;
        }


        int
        f_10171_1264_1299(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10171, 1264, 1299);
            return 0;
        }


        int
        f_10171_1314_1362(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10171, 1314, 1362);
            return 0;
        }


        int
        f_10171_1377_1422(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10171, 1377, 1422);
            return 0;
        }

    }
    internal static class TypeParameterBoundsExtensions
    {
        internal static bool IsSet(this TypeParameterBounds boundsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10171, 3973, 4117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10171, 4060, 4106);

                return boundsOpt != TypeParameterBounds.Unset;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10171, 3973, 4117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10171, 3973, 4117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10171, 3973, 4117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterBoundsExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10171, 3905, 4124);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10171, 3905, 4124);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10171, 3905, 4124);
        }

    }
}
