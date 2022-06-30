// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal sealed class CustomModifiersTuple
    {
        private readonly ImmutableArray<CustomModifier> _typeCustomModifiers;

        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        public static readonly CustomModifiersTuple Empty;

        private CustomModifiersTuple(ImmutableArray<CustomModifier> typeCustomModifiers, ImmutableArray<CustomModifier> refCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(590, 669, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 825, 882);

                _typeCustomModifiers = typeCustomModifiers.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 896, 951);

                _refCustomModifiers = refCustomModifiers.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(590, 669, 962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(590, 669, 962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(590, 669, 962);
            }
        }

        public static CustomModifiersTuple Create(ImmutableArray<CustomModifier> typeCustomModifiers, ImmutableArray<CustomModifier> refCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(590, 974, 1384);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 1143, 1284) || true) && (typeCustomModifiers.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(590, 1147, 1222) && refCustomModifiers.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(590, 1143, 1284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 1256, 1269);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(590, 1143, 1284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 1300, 1373);

                return f_590_1307_1372(typeCustomModifiers, refCustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(590, 974, 1384);

                Microsoft.CodeAnalysis.CustomModifiersTuple
                f_590_1307_1372(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                typeCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomModifiersTuple(typeCustomModifiers, refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(590, 1307, 1372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(590, 974, 1384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(590, 974, 1384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<CustomModifier> TypeCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(590, 1456, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 1462, 1490);

                    return _typeCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(590, 1456, 1492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(590, 1396, 1494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(590, 1396, 1494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(590, 1563, 1598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 1569, 1596);

                    return _refCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(590, 1563, 1598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(590, 1504, 1600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(590, 1504, 1600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static CustomModifiersTuple()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(590, 288, 1607);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(590, 548, 656);
            Empty = f_590_556_656(ImmutableArray<CustomModifier>.Empty, ImmutableArray<CustomModifier>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(590, 288, 1607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(590, 288, 1607);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(590, 288, 1607);

        static Microsoft.CodeAnalysis.CustomModifiersTuple
        f_590_556_656(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        typeCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        refCustomModifiers)
        {
            var return_v = new Microsoft.CodeAnalysis.CustomModifiersTuple(typeCustomModifiers, refCustomModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(590, 556, 656);
            return return_v;
        }

    }
}
