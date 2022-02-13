// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal readonly struct TypeWithAnnotations : IFormattable
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal sealed class Boxed
        {
            internal static readonly Boxed Sentinel;

            internal readonly TypeWithAnnotations Value;

            internal Boxed(TypeWithAnnotations value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 991, 1094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1065, 1079);

                    Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 991, 1094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 991, 1094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 991, 1094);
                }
            }

            internal string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 1145, 1174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1148, 1174);
                    return Value.GetDebuggerDisplay(); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 1145, 1174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 1145, 1174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 1145, 1174);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Boxed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 747, 1186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 887, 916);
                Sentinel = f_10176_898_916(default); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 747, 1186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 747, 1186);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10176, 747, 1186);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
            f_10176_898_916(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            value)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 898, 916);
                return return_v;
            }

        }

        internal readonly TypeSymbol DefaultType;

        private readonly Extensions _extensions;

        public readonly NullableAnnotation NullableAnnotation;

        private TypeWithAnnotations(TypeSymbol defaultType, NullableAnnotation nullableAnnotation, Extensions extensions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 1641, 2214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1802, 1831);

                var
                a1 = defaultType is null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1845, 1896);

                var
                a2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 1854, 1857) || ((!a1 && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 1860, 1888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 1891, 1895))) ? f_10176_1860_1888(defaultType) : true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1910, 1970);

                var
                a3 = nullableAnnotation == NullableAnnotation.Annotated
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 1984, 2021);

                f_10176_1984_2020(a1 || (DynAbs.Tracing.TraceSender.Expression_False(10176, 1997, 2013) || a2 != true) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 1997, 2019) || a3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2035, 2068);

                f_10176_2035_2067(extensions != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2084, 2110);

                DefaultType = defaultType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2124, 2164);

                NullableAnnotation = nullableAnnotation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2178, 2203);

                _extensions = extensions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 1641, 2214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 1641, 2214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 1641, 2214);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 2260, 2278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2263, 2278);
                return f_10176_2263_2278(Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 2260, 2278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 2260, 2278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 2260, 2278);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_10176_2263_2278(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 2263, 2278);
                return return_v;
            }

        }

        private static readonly SymbolDisplayFormat DebuggerDisplayFormat;

        internal static readonly SymbolDisplayFormat TestDisplayFormat;

        internal static TypeWithAnnotations Create(bool isNullableEnabled, TypeSymbol typeSymbol, bool isAnnotated = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 3276, 3704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 3416, 3502) || true) && (typeSymbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 3416, 3502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 3472, 3487);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 3416, 3502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 3518, 3693);

                return Create(typeSymbol, nullableAnnotation: (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 3564, 3575) || ((isAnnotated && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 3578, 3606)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 3609, 3691))) ? NullableAnnotation.Annotated : (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 3609, 3626) || ((isNullableEnabled && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 3629, 3660)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 3663, 3691))) ? NullableAnnotation.NotAnnotated : NullableAnnotation.Oblivious);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 3276, 3704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 3276, 3704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 3276, 3704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeWithAnnotations Create(TypeSymbol typeSymbol, NullableAnnotation nullableAnnotation = NullableAnnotation.Oblivious, ImmutableArray<CustomModifier> customModifiers = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 3716, 4783);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 3934, 4047) || true) && (typeSymbol is null && (DynAbs.Tracing.TraceSender.Expression_True(10176, 3938, 3983) && nullableAnnotation == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 3934, 4047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4017, 4032);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 3934, 4047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4063, 4158);

                f_10176_4063_4157(nullableAnnotation != NullableAnnotation.Ignored || (DynAbs.Tracing.TraceSender.Expression_False(10176, 4076, 4156) || f_10176_4128_4156(typeSymbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4172, 4668);

                switch (nullableAnnotation)
                {

                    case NullableAnnotation.Oblivious:
                    case NullableAnnotation.NotAnnotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 4172, 4668);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4374, 4625) || true) && (typeSymbol is not null && (DynAbs.Tracing.TraceSender.Expression_True(10176, 4378, 4431) && f_10176_4404_4431(typeSymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 4374, 4625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4552, 4602);

                            nullableAnnotation = NullableAnnotation.Annotated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 4374, 4625);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10176, 4647, 4653);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 4172, 4668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4684, 4772);

                return CreateNonLazyType(typeSymbol, nullableAnnotation, customModifiers.NullToEmpty());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 3716, 4783);

                bool
                f_10176_4128_4156(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 4128, 4156);
                    return return_v;
                }


                int
                f_10176_4063_4157(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 4063, 4157);
                    return 0;
                }


                bool
                f_10176_4404_4431(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 4404, 4431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 3716, 4783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 3716, 4783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations AsAnnotated()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 4795, 5100);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4862, 5006) || true) && (f_10176_4866_4898(NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 4866, 4945) || (f_10176_4903_4919(Type) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 4903, 4944) && f_10176_4923_4944(Type)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 4862, 5006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 4979, 4991);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 4862, 5006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5022, 5089);

                return Create(Type, NullableAnnotation.Annotated, CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 4795, 5100);

                bool
                f_10176_4866_4898(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 4866, 4898);
                    return return_v;
                }


                bool
                f_10176_4903_4919(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 4903, 4919);
                    return return_v;
                }


                bool
                f_10176_4923_4944(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 4923, 4944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 4795, 5100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 4795, 5100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations AsNotAnnotated()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 5112, 5427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5182, 5330) || true) && (f_10176_5186_5221(NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 5186, 5269) || (f_10176_5226_5242(Type) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 5226, 5268) && !f_10176_5247_5268(Type)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 5182, 5330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5303, 5315);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 5182, 5330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5346, 5416);

                return Create(Type, NullableAnnotation.NotAnnotated, CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 5112, 5427);

                bool
                f_10176_5186_5221(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsNotAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 5186, 5221);
                    return return_v;
                }


                bool
                f_10176_5226_5242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 5226, 5242);
                    return return_v;
                }


                bool
                f_10176_5247_5268(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 5247, 5268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 5112, 5427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 5112, 5427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NullableAnnotation GetValueNullableAnnotation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 5483, 6072);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5564, 5675) || true) && (f_10176_5568_5600(NullableAnnotation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 5564, 5675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5634, 5660);

                    return NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 5564, 5675);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5714, 5878) || true) && (Type is null && (DynAbs.Tracing.TraceSender.Expression_True(10176, 5718, 5793) && f_10176_5734_5785(Type) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 5714, 5878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5827, 5863);

                    return NullableAnnotation.Annotated;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 5714, 5878);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5894, 6019) || true) && (f_10176_5898_5934(Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 5894, 6019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 5968, 6004);

                    return NullableAnnotation.Annotated;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 5894, 6019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6035, 6061);

                return NullableAnnotation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 5483, 6072);

                bool
                f_10176_5568_5600(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 5568, 5600);
                    return return_v;
                }


                bool
                f_10176_5734_5785(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsPossiblyNullableReferenceTypeTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 5734, 5785);
                    return return_v;
                }


                bool
                f_10176_5898_5934(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 5898, 5934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 5483, 6072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 5483, 6072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CanBeAssignedNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 6140, 6656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6176, 6641);

                    switch (NullableAnnotation)
                    {

                        case NullableAnnotation.Oblivious:
                        case NullableAnnotation.Annotated:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 6176, 6641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6360, 6372);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 6176, 6641);

                        case NullableAnnotation.NotAnnotated:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 6176, 6641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6459, 6503);

                            return f_10176_6466_6502(Type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 6176, 6641);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 6176, 6641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6561, 6622);

                            throw f_10176_6567_6621(NullableAnnotation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 6176, 6641);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 6140, 6656);

                    bool
                    f_10176_6466_6502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableTypeOrTypeParameter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 6466, 6502);
                        return return_v;
                    }


                    System.Exception
                    f_10176_6567_6621(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 6567, 6621);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 6084, 6667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 6084, 6667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static TypeWithAnnotations CreateNonLazyType(TypeSymbol typeSymbol, NullableAnnotation nullableAnnotation, ImmutableArray<CustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 6679, 6976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 6866, 6965);

                return f_10176_6873_6964(typeSymbol, nullableAnnotation, f_10176_6929_6963(customModifiers));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 6679, 6976);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                f_10176_6929_6963(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = Extensions.Create(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 6929, 6963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10176_6873_6964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                defaultType, Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                nullableAnnotation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                extensions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations(defaultType, nullableAnnotation, extensions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 6873, 6964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 6679, 6976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 6679, 6976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations CreateLazyNullableType(CSharpCompilation compilation, TypeWithAnnotations underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 6988, 7310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 7133, 7299);

                return f_10176_7140_7298(defaultType: underlying.DefaultType, nullableAnnotation: NullableAnnotation.Annotated, f_10176_7251_7297(compilation, underlying));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 6988, 7310);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                f_10176_7251_7297(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                underlying)
                {
                    var return_v = Extensions.CreateLazy(compilation, underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 7251, 7297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10176_7140_7298(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                defaultType, Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                nullableAnnotation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                extensions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations(defaultType: defaultType, nullableAnnotation: nullableAnnotation, extensions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 7140, 7298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 6988, 7310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 6988, 7310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 7518, 7634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 7521, 7634);
                    return DefaultType is null && (DynAbs.Tracing.TraceSender.Expression_True(10176, 7521, 7572) && this.NullableAnnotation == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 7521, 7634) && (_extensions == null || (DynAbs.Tracing.TraceSender.Expression_False(10176, 7577, 7633) || _extensions == Extensions.Default))); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 7518, 7634);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 7518, 7634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 7518, 7634);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 7759, 7784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 7762, 7784);
                    return !(DefaultType is null); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 7759, 7784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 7759, 7784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 7759, 7784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeWithAnnotations SetIsAnnotated(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 7815, 9236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 7912, 7950);

                f_10176_7912_7949(CustomModifiers.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 7966, 7993);

                var
                typeSymbol = this.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8009, 8441) || true) && (f_10176_8013_8032(typeSymbol) != TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 8009, 8441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8092, 8426) || true) && (f_10176_8096_8119_M(!typeSymbol.IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 8096, 8148) && !f_10176_8124_8148(typeSymbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 8092, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8190, 8279);

                        return CreateNonLazyType(typeSymbol, NullableAnnotation.Annotated, this.CustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 8092, 8426);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 8092, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8361, 8407);

                        return makeNullableT(compilation, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 8092, 8426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 8009, 8441);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8457, 8719) || true) && (f_10176_8461_8512(((TypeParameterSymbol)typeSymbol)) == TypeParameterKind.Cref)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 8457, 8719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8658, 8704);

                    return makeNullableT(compilation, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 8457, 8719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 8938, 8987);

                return CreateLazyNullableType(compilation, this);

                TypeWithAnnotations makeNullableT(CSharpCompilation comp, TypeSymbol typeSym)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 9121, 9224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 9124, 9224);
                        return Create(f_10176_9131_9223(f_10176_9131_9181(comp, SpecialType.System_Nullable_T), f_10176_9192_9222(typeSym))); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 9121, 9224);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 9121, 9224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 9121, 9224);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 7815, 9236);

                int
                f_10176_7912_7949(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 7912, 7949);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10176_8013_8032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 8013, 8032);
                    return return_v;
                }


                bool
                f_10176_8096_8119_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 8096, 8119);
                    return return_v;
                }


                bool
                f_10176_8124_8148(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 8124, 8148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeParameterKind
                f_10176_8461_8512(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameterKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 8461, 8512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10176_9131_9181(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9131, 9181);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10176_9192_9222(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9192, 9222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10176_9131_9223(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9131, 9223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 7815, 9236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 7815, 9236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void TryForceResolve(bool asValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 9407, 9529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 9477, 9518);

                f_10176_9477_9517(_extensions, asValueType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 9407, 9529);

                int
                f_10176_9477_9517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                this_param, bool
                asValueType)
                {
                    this_param.TryForceResolve(asValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9477, 9517);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 9407, 9529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 9407, 9529);
            }
        }

        private TypeWithAnnotations AsNullableReferenceType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 9595, 9639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 9598, 9639);
                return f_10176_9598_9639(_extensions, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 9595, 9639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 9595, 9639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 9595, 9639);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_9598_9639(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type)
            {
                var return_v = this_param.AsNullableReferenceType(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9598, 9639);
                return return_v;
            }

        }

        public TypeWithAnnotations AsNotNullableReferenceType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 9706, 9753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 9709, 9753);
                return f_10176_9709_9753(_extensions, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 9706, 9753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 9706, 9753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 9706, 9753);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_9709_9753(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type)
            {
                var return_v = this_param.AsNotNullableReferenceType(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 9709, 9753);
                return return_v;
            }

        }

        internal TypeWithAnnotations MergeEquivalentTypes(TypeWithAnnotations other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 9934, 10442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10058, 10093);

                TypeSymbol
                typeSymbol = other.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10107, 10231);

                NullableAnnotation
                nullableAnnotation = f_10176_10147_10230(this.NullableAnnotation, other.NullableAnnotation, variance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10245, 10311);

                TypeSymbol
                type = f_10176_10263_10310(Type, typeSymbol, variance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10325, 10360);

                f_10176_10325_10359((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10374, 10431);

                return Create(type, nullableAnnotation, CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 9934, 10442);

                Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                f_10176_10147_10230(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                a, Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                b, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = a.MergeNullableAnnotation(b, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10147, 10230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10176_10263_10310(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                other, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = this_param.MergeEquivalentTypes(other, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10263, 10310);
                    return return_v;
                }


                int
                f_10176_10325_10359(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10325, 10359);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 9934, 10442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 9934, 10442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations WithModifiers(ImmutableArray<CustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 10543, 10607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10559, 10607);
                return f_10176_10559_10607(_extensions, this, customModifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 10543, 10607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 10543, 10607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 10543, 10607);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_10559_10607(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            customModifiers)
            {
                var return_v = this_param.WithModifiers(type, customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10559, 10607);
                return return_v;
            }

        }

        public bool IsResolved
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 10643, 10678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10646, 10678);
                    return f_10176_10646_10669_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_extensions, 10176, 10646, 10669)?.IsResolved) != false; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 10643, 10678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 10643, 10678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 10643, 10678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 10712, 10756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10715, 10756);
                    return f_10176_10715_10756_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_extensions, 10176, 10715, 10756)?.GetResolvedType(DefaultType)); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 10712, 10756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 10712, 10756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 10712, 10756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeSymbol NullableUnderlyingTypeOrSelf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 10814, 10873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 10817, 10873);
                    return f_10176_10817_10873(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 10814, 10873);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 10814, 10873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 10814, 10873);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNullableType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11248, 11272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11251, 11272);
                return f_10176_11251_11272(Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11248, 11272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11248, 11272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11248, 11272);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_11251_11272(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = type.IsNullableType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 11251, 11272);
                return return_v;
            }

        }

        public ImmutableArray<CustomModifier> CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11477, 11507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11480, 11507);
                    return f_10176_11480_11507(_extensions); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11477, 11507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11477, 11507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11477, 11507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11545, 11561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11548, 11561);
                    return f_10176_11548_11561(Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11545, 11561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11545, 11561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11545, 11561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SpecialType SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11603, 11645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11606, 11645);
                    return f_10176_11606_11645(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11603, 11645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11603, 11645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11603, 11645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.PrimitiveTypeCode PrimitiveTypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11703, 11728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11706, 11728);
                    return f_10176_11706_11728(Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11703, 11728);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11703, 11728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11703, 11728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsVoidType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11766, 11813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11782, 11813);
                return f_10176_11782_11813(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11766, 11813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11766, 11813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11766, 11813);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_11782_11813(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol)
            {
                var return_v = this_param.IsVoid(typeSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 11782, 11813);
                return return_v;
            }

        }

        public bool IsSZArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11848, 11898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11864, 11898);
                return f_10176_11864_11898(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11848, 11898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11848, 11898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11848, 11898);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_11864_11898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol)
            {
                var return_v = this_param.IsSZArray(typeSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 11864, 11898);
                return return_v;
            }

        }

        public bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 11930, 11979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 11946, 11979);
                    return f_10176_11946_11979(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 11930, 11979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 11930, 11979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 11930, 11979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRestrictedType(bool ignoreSpanLikeTypes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 12053, 12131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12069, 12131);
                return f_10176_12069_12131(_extensions, DefaultType, ignoreSpanLikeTypes); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 12053, 12131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 12053, 12131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 12053, 12131);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_12069_12131(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, bool
            ignoreSpanLikeTypes)
            {
                var return_v = this_param.IsRestrictedType(typeSymbol, ignoreSpanLikeTypes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12069, 12131);
                return return_v;
            }

        }

        public string ToDisplayString(SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 12144, 13673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12233, 12748) || true) && (f_10176_12237_12248_M(!IsResolved))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12233, 12748);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12282, 12733) || true) && (!IsSafeToResolve())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12282, 12733);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12346, 12647) || true) && (f_10176_12350_12382(NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 12350, 12525) && f_10176_12411_12525(f_10176_12411_12438(format), SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12346, 12647);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12575, 12624);

                            return f_10176_12582_12617(DefaultType, format) + "?";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12346, 12647);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12671, 12714);

                        return f_10176_12678_12713(DefaultType, format);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12282, 12733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12233, 12748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12764, 12825);

                var
                str = (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 12774, 12782) || ((f_10176_12774_12782_M(!HasType) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 12785, 12793)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 12796, 12824))) ? "<null>" : f_10176_12796_12824(Type, format)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12839, 13635) || true) && (format != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12839, 13635);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 12891, 13620) || true) && (f_10176_12895_12927(NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 12895, 13066) && f_10176_12952_13066(f_10176_12952_12979(format), SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 12895, 13145) && (f_10176_13092_13100_M(!HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 13092, 13144) || (!IsNullableType() && (DynAbs.Tracing.TraceSender.Expression_True(10176, 13105, 13143) && f_10176_13126_13143_M(!Type.IsValueType)))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12891, 13620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 13187, 13204);

                        return str + "?";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12891, 13620);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 12891, 13620);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 13246, 13620) || true) && (f_10176_13250_13285(NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 13250, 13427) && f_10176_13310_13427(f_10176_13310_13337(format), SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 13250, 13542) && (f_10176_13453_13461_M(!HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 13453, 13541) || (f_10176_13466_13483_M(!Type.IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 13466, 13540) && !f_10176_13488_13540(Type)))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 13246, 13620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 13584, 13601);

                            return str + "!";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 13246, 13620);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12891, 13620);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 12839, 13635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 13651, 13662);

                return str;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 12144, 13673);

                bool
                f_10176_12237_12248_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 12237, 12248);
                    return return_v;
                }


                bool
                f_10176_12350_12382(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12350, 12382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10176_12411_12438(Microsoft.CodeAnalysis.SymbolDisplayFormat?
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 12411, 12438);
                    return return_v;
                }


                bool
                f_10176_12411_12525(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12411, 12525);
                    return return_v;
                }


                string
                f_10176_12582_12617(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12582, 12617);
                    return return_v;
                }


                string
                f_10176_12678_12713(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12678, 12713);
                    return return_v;
                }


                bool
                f_10176_12774_12782_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 12774, 12782);
                    return return_v;
                }


                string
                f_10176_12796_12824(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12796, 12824);
                    return return_v;
                }


                bool
                f_10176_12895_12927(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12895, 12927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10176_12952_12979(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 12952, 12979);
                    return return_v;
                }


                bool
                f_10176_12952_13066(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 12952, 13066);
                    return return_v;
                }


                bool
                f_10176_13092_13100_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13092, 13100);
                    return return_v;
                }


                bool
                f_10176_13126_13143_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13126, 13143);
                    return return_v;
                }


                bool
                f_10176_13250_13285(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsNotAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 13250, 13285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10176_13310_13337(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13310, 13337);
                    return return_v;
                }


                bool
                f_10176_13310_13427(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 13310, 13427);
                    return return_v;
                }


                bool
                f_10176_13453_13461_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13453, 13461);
                    return return_v;
                }


                bool
                f_10176_13466_13483_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13466, 13483);
                    return return_v;
                }


                bool
                f_10176_13488_13540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 13488, 13540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 12144, 13673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 12144, 13673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSafeToResolve()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 13685, 14273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 13885, 14034);

                var
                declaringMethod = (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 13907, 13943) || (((DefaultType is TypeParameterSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 13946, 14026)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 14029, 14033))) ? f_10176_13946_13996(((TypeParameterSymbol)DefaultType)) as SourceOrdinaryMethodSymbol : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14048, 14262);

                return !((object)declaringMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10176, 14057, 14155) && !f_10176_14093_14155(declaringMethod, CompletionPart.FinishMethodChecks)) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 14057, 14260) && (f_10176_14180_14206(declaringMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 14180, 14259) || f_10176_14210_14259(declaringMethod)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 13685, 14273);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10176_13946_13996(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 13946, 13996);
                    return return_v;
                }


                bool
                f_10176_14093_14155(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CompletionPart
                part)
                {
                    var return_v = this_param.HasComplete(part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 14093, 14155);
                    return return_v;
                }


                bool
                f_10176_14180_14206(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14180, 14206);
                    return return_v;
                }


                bool
                f_10176_14210_14259(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14210, 14259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 13685, 14273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 13685, 14273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 14322, 14390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14325, 14390);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 14325, 14338) || ((f_10176_14325_14338_M(!this.HasType) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 14341, 14349)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 14352, 14390))) ? "<null>" : ToDisplayString(DebuggerDisplayFormat); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 14322, 14390);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 14322, 14390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 14322, 14390);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_14325_14338_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14325, 14338);
                return return_v;
            }

        }

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 14403, 14583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14503, 14572);

                return ToDisplayString(f_10176_14526_14570());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 14403, 14583);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10176_14526_14570()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14526, 14570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 14403, 14583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 14403, 14583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(TypeWithAnnotations other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 14595, 16308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14693, 14778) || true) && (this.IsSameAs(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 14693, 14778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14751, 14763);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 14693, 14778);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14794, 15085) || true) && (f_10176_14798_14806_M(!HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 14794, 15085);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14840, 14931) || true) && (other.HasType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 14840, 14931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14899, 14912);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 14840, 14931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 14794, 15085);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 14794, 15085);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 14965, 15085) || true) && (f_10176_14969_14983_M(!other.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 14969, 15023) || !TypeSymbolEquals(other, comparison)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 14965, 15085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15057, 15070);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 14965, 15085);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 14794, 15085);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15158, 15387) || true) && ((comparison & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10176, 15162, 15325) && !this.CustomModifiers.SequenceEqual(other.CustomModifiers)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 15158, 15387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15359, 15372);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 15158, 15387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15403, 15443);

                var
                thisAnnotation = NullableAnnotation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15457, 15504);

                var
                otherAnnotation = other.NullableAnnotation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15520, 16269) || true) && ((comparison & TypeCompareKind.IgnoreNullableModifiersForReferenceTypes) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 15520, 16269);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15634, 16254) || true) && (otherAnnotation != thisAnnotation && (DynAbs.Tracing.TraceSender.Expression_True(10176, 15638, 15838) && ((comparison & TypeCompareKind.ObliviousNullableModifierMatchesAny) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10176, 15697, 15837) || (!f_10176_15774_15802(thisAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 15773, 15836) && !f_10176_15807_15836(otherAnnotation)))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 15634, 16254);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15880, 15978) || true) && (f_10176_15884_15892_M(!HasType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 15880, 15978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 15942, 15955);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 15880, 15978);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16002, 16025);

                        TypeSymbol
                        type = Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16047, 16109);

                        bool
                        isValueType = f_10176_16066_16082(type) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 16066, 16108) && !f_10176_16087_16108(type))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16133, 16235) || true) && (!isValueType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 16133, 16235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16199, 16212);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 16133, 16235);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 15634, 16254);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 15520, 16269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16285, 16297);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 14595, 16308);

                bool
                f_10176_14798_14806_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14798, 14806);
                    return return_v;
                }


                bool
                f_10176_14969_14983_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 14969, 14983);
                    return return_v;
                }


                bool
                f_10176_15774_15802(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 15774, 15802);
                    return return_v;
                }


                bool
                f_10176_15807_15836(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 15807, 15836);
                    return return_v;
                }


                bool
                f_10176_15884_15892_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 15884, 15892);
                    return return_v;
                }


                bool
                f_10176_16066_16082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 16066, 16082);
                    return return_v;
                }


                bool
                f_10176_16087_16108(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 16087, 16108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 14595, 16308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 14595, 16308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class EqualsComparer : EqualityComparer<TypeWithAnnotations>
        {
            internal static readonly EqualsComparer ConsiderEverythingComparer;

            internal static readonly EqualsComparer IgnoreNullableModifiersForReferenceTypesComparer;

            private readonly TypeCompareKind _compareKind;

            public EqualsComparer(TypeCompareKind compareKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 16805, 16930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16776, 16788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16888, 16915);

                    _compareKind = compareKind;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 16805, 16930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 16805, 16930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 16805, 16930);
                }
            }

            public override int GetHashCode(TypeWithAnnotations obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 16946, 17184);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17035, 17121) || true) && (f_10176_17039_17051_M(!obj.HasType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 17035, 17121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17093, 17102);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 17035, 17121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17139, 17169);

                    return f_10176_17146_17168(obj.Type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 16946, 17184);

                    bool
                    f_10176_17039_17051_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 17039, 17051);
                        return return_v;
                    }


                    int
                    f_10176_17146_17168(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 17146, 17168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 16946, 17184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 16946, 17184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(TypeWithAnnotations x, TypeWithAnnotations y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 17200, 17465);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17306, 17399) || true) && (f_10176_17310_17320_M(!x.HasType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 17306, 17399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17362, 17380);

                        return f_10176_17369_17379_M(!y.HasType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 17306, 17399);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17417, 17450);

                    return x.Equals(y, _compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 17200, 17465);

                    bool
                    f_10176_17310_17320_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 17310, 17320);
                        return return_v;
                    }


                    bool
                    f_10176_17369_17379_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 17369, 17379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 17200, 17465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 17200, 17465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static EqualsComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 16320, 17476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16461, 16544);
                ConsiderEverythingComparer = f_10176_16490_16544(TypeCompareKind.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 16599, 16726);
                IgnoreNullableModifiersForReferenceTypesComparer = f_10176_16650_16726(TypeCompareKind.IgnoreNullableModifiersForReferenceTypes); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 16320, 17476);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 16320, 17476);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10176, 16320, 17476);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer
            f_10176_16490_16544(Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer(compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 16490, 16544);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer
            f_10176_16650_16726(Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer(compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 16650, 16726);
                return return_v;
            }

        }

        internal bool TypeSymbolEquals(TypeWithAnnotations other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 17574, 17643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17590, 17643);
                return f_10176_17590_17643(_extensions, this, other, comparison); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 17574, 17643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 17574, 17643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 17574, 17643);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10176_17590_17643(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            other, Microsoft.CodeAnalysis.TypeCompareKind
            comparison)
            {
                var return_v = this_param.TypeSymbolEquals(type, other, comparison);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 17590, 17643);
                return return_v;
            }

        }

        public bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 17656, 18043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 17812, 18032);

                return f_10176_17819_17901(Type, ref result, owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 17819, 18031) || f_10176_17925_18031(ref result, this.CustomModifiers, owner, ref checkedTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 17656, 18043);

                bool
                f_10176_17819_17901(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 17819, 17901);
                    return return_v;
                }


                bool
                f_10176_17925_18031(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = Symbol.GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 17925, 18031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 17656, 18043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 17656, 18043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsAtLeastAsVisibleAs(Symbol sym, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 18055, 18357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18260, 18346);

                return f_10176_18267_18345(NullableUnderlyingTypeOrSelf, sym, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 18055, 18357);

                bool
                f_10176_18267_18345(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                sym, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = type.IsAtLeastAsVisibleAs(sym, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 18267, 18345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 18055, 18357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 18055, 18357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations SubstituteType(AbstractTypeMap typeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 18436, 18493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18452, 18493);
                return f_10176_18452_18493(_extensions, this, typeMap); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 18436, 18493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 18436, 18493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 18436, 18493);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_18452_18493(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
            typeMap)
            {
                var return_v = this_param.SubstituteType(type, typeMap);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 18452, 18493);
                return return_v;
            }

        }

        internal TypeWithAnnotations SubstituteTypeCore(AbstractTypeMap typeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 18506, 22397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18751, 18814);

                f_10176_18751_18813(NullableAnnotation != NullableAnnotation.Ignored);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18830, 18911);

                var
                newCustomModifiers = f_10176_18855_18910(typeMap, this.CustomModifiers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18925, 18959);

                TypeSymbol
                typeSymbol = this.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 18973, 19035);

                var
                newTypeWithModifiers = f_10176_19000_19034(typeMap, typeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19051, 20114) || true) && (!f_10176_19056_19084(typeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 19051, 20114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19118, 19276);

                    f_10176_19118_19275(f_10176_19131_19184(newTypeWithModifiers.NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 19131, 19274) || (f_10176_19189_19216(typeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 19189, 19273) && f_10176_19220_19273(newTypeWithModifiers.NullableAnnotation)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19294, 19353);

                    f_10176_19294_19352(newTypeWithModifiers.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19371, 19434);

                    f_10176_19371_19433(NullableAnnotation != NullableAnnotation.Ignored);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19454, 19998) || true) && (f_10176_19458_19538(typeSymbol, newTypeWithModifiers.Type, TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 19458, 19600) && newCustomModifiers == CustomModifiers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 19454, 19998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19642, 19654);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 19454, 19998);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 19454, 19998);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19751, 19998) || true) && ((f_10176_19756_19788(NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 19756, 19857) || (f_10176_19793_19820(typeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 19793, 19856) && f_10176_19824_19856(NullableAnnotation))))) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 19755, 19909) && newCustomModifiers.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 19751, 19998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 19951, 19979);

                            return newTypeWithModifiers;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 19751, 19998);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 19454, 19998);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20018, 20099);

                    return Create(newTypeWithModifiers.Type, NullableAnnotation, newCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 19051, 20114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20130, 20572) || true) && (newTypeWithModifiers.Is((TypeParameterSymbol)typeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 20134, 20248) && newCustomModifiers == CustomModifiers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20130, 20572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20282, 20294);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20130, 20572);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20130, 20572);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20383, 20572) || true) && (Is((TypeParameterSymbol)typeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 20387, 20495) && newTypeWithModifiers.NullableAnnotation != NullableAnnotation.Ignored))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20383, 20572);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20529, 20557);

                        return newTypeWithModifiers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20383, 20572);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20130, 20572);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20588, 20727) || true) && (newTypeWithModifiers.Type is PlaceholderTypeArgumentSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20588, 20727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20684, 20712);

                    return newTypeWithModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20588, 20727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20743, 20776);

                NullableAnnotation
                newAnnotation
                = default(NullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20790, 20937);

                f_10176_20790_20936(newTypeWithModifiers.Type is not IndexedTypeParameterSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10176, 20803, 20935) || newTypeWithModifiers.NullableAnnotation == NullableAnnotation.Ignored));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 20953, 22186) || true) && (f_10176_20957_20989(NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 20957, 21046) || f_10176_20993_21046(newTypeWithModifiers.NullableAnnotation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20953, 22186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21080, 21125);

                    newAnnotation = NullableAnnotation.Annotated;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20953, 22186);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 20953, 22186);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21159, 22186) || true) && (newTypeWithModifiers.NullableAnnotation == NullableAnnotation.Ignored)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21159, 22186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21266, 21301);

                        newAnnotation = NullableAnnotation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21159, 22186);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21159, 22186);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21335, 22186) || true) && (NullableAnnotation != NullableAnnotation.Oblivious)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21335, 22186);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21423, 21720) || true) && (!f_10176_21428_21486(typeSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21423, 21720);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21528, 21563);

                                newAnnotation = NullableAnnotation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21423, 21720);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21423, 21720);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21645, 21701);

                                newAnnotation = newTypeWithModifiers.NullableAnnotation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21423, 21720);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21335, 22186);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21335, 22186);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21754, 22186) || true) && (newTypeWithModifiers.NullableAnnotation != NullableAnnotation.Oblivious)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21754, 22186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21863, 21919);

                                newAnnotation = newTypeWithModifiers.NullableAnnotation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21754, 22186);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 21754, 22186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 21985, 22032);

                                f_10176_21985_22031(f_10176_21998_22030(NullableAnnotation));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22050, 22118);

                                f_10176_22050_22117(f_10176_22063_22116(newTypeWithModifiers.NullableAnnotation));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22136, 22171);

                                newAnnotation = NullableAnnotation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21754, 22186);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21335, 22186);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 21159, 22186);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 20953, 22186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22202, 22386);

                return CreateNonLazyType(newTypeWithModifiers.Type, newAnnotation, newCustomModifiers.Concat(newTypeWithModifiers.CustomModifiers));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 18506, 22397);

                int
                f_10176_18751_18813(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 18751, 18813);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10176_18855_18910(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 18855, 18910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10176_19000_19034(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19000, 19034);
                    return return_v;
                }


                bool
                f_10176_19056_19084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19056, 19084);
                    return return_v;
                }


                bool
                f_10176_19131_19184(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19131, 19184);
                    return return_v;
                }


                bool
                f_10176_19189_19216(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19189, 19216);
                    return return_v;
                }


                bool
                f_10176_19220_19273(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19220, 19273);
                    return return_v;
                }


                int
                f_10176_19118_19275(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19118, 19275);
                    return 0;
                }


                int
                f_10176_19294_19352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19294, 19352);
                    return 0;
                }


                int
                f_10176_19371_19433(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19371, 19433);
                    return 0;
                }


                bool
                f_10176_19458_19538(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19458, 19538);
                    return return_v;
                }


                bool
                f_10176_19756_19788(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19756, 19788);
                    return return_v;
                }


                bool
                f_10176_19793_19820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19793, 19820);
                    return return_v;
                }


                bool
                f_10176_19824_19856(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 19824, 19856);
                    return return_v;
                }


                int
                f_10176_20790_20936(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 20790, 20936);
                    return 0;
                }


                bool
                f_10176_20957_20989(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 20957, 20989);
                    return return_v;
                }


                bool
                f_10176_20993_21046(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 20993, 21046);
                    return return_v;
                }


                bool
                f_10176_21428_21486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 21428, 21486);
                    return return_v;
                }


                bool
                f_10176_21998_22030(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 21998, 22030);
                    return return_v;
                }


                int
                f_10176_21985_22031(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 21985, 22031);
                    return 0;
                }


                bool
                f_10176_22063_22116(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 22063, 22116);
                    return return_v;
                }


                int
                f_10176_22050_22117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 22050, 22117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 18506, 22397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 18506, 22397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ReportDiagnosticsIfObsolete(Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 22510, 22600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22526, 22600);
                f_10176_22526_22600(_extensions, this, binder, syntax, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 22510, 22600);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 22510, 22600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 22510, 22600);
            }

            int
            f_10176_22526_22600(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.CSharp.Binder
            binder, Microsoft.CodeAnalysis.SyntaxNode
            syntax, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                this_param.ReportDiagnosticsIfObsolete(type, binder, syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 22526, 22600);
                return 0;
            }

        }

        private bool TypeSymbolEqualsCore(TypeWithAnnotations other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 22613, 22780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22726, 22769);

                return f_10176_22733_22768(Type, other.Type, comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 22613, 22780);

                bool
                f_10176_22733_22768(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 22733, 22768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 22613, 22780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 22613, 22780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportDiagnosticsIfObsoleteCore(Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 22792, 23019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 22922, 23008);

                f_10176_22922_23007(binder, diagnostics, Type, syntax, hasBaseReceiver: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 22792, 23019);

                int
                f_10176_22922_23007(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 22922, 23007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 22792, 23019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 22792, 23019);
            }
        }

        public TypeSymbol AsTypeSymbolOnly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 23258, 23302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 23261, 23302);
                return f_10176_23261_23302(_extensions, DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 23258, 23302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 23258, 23302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 23258, 23302);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10176_23261_23302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol)
            {
                var return_v = this_param.AsTypeSymbolOnly(typeSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 23261, 23302);
                return return_v;
            }

        }

        public bool Is(TypeParameterSymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 23409, 23607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 23475, 23596);

                return f_10176_23482_23514(NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 23482, 23548) && ((object)DefaultType == other)) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 23482, 23595) && CustomModifiers.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 23409, 23607);

                bool
                f_10176_23482_23514(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 23482, 23514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 23409, 23607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 23409, 23607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations WithTypeAndModifiers(TypeSymbol typeSymbol, ImmutableArray<CustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 23738, 23821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 23754, 23821);
                return f_10176_23754_23821(_extensions, this, typeSymbol, customModifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 23738, 23821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 23738, 23821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 23738, 23821);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_23754_23821(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            customModifiers)
            {
                var return_v = this_param.WithTypeAndModifiers(type, typeSymbol, customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 23754, 23821);
                return return_v;
            }

        }

        public TypeWithAnnotations WithType(TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 23893, 23976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 23909, 23976);
                return f_10176_23909_23976(_extensions, this, typeSymbol, CustomModifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 23893, 23976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 23893, 23976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 23893, 23976);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10176_23909_23976(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            customModifiers)
            {
                var return_v = this_param.WithTypeAndModifiers(type, typeSymbol, customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 23909, 23976);
                return return_v;
            }

        }

        public bool NeedsNullableAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 24764, 24887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 24825, 24876);

                return NeedsNullableAttribute(this, typeOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 24764, 24887);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 24764, 24887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 24764, 24887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NeedsNullableAttribute(
                    TypeWithAnnotations typeWithAnnotationsOpt,
                    TypeSymbol typeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 24899, 25455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25056, 25402);

                var
                type = TypeSymbolExtensions.VisitType(typeWithAnnotationsOpt, typeOpt, typeWithAnnotationsPredicate: (t, a, b) => t.NullableAnnotation != NullableAnnotation.Oblivious && !t.Type.IsErrorType() && !t.Type.IsValueType, typePredicate: null, (object)null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25416, 25444);

                return (object)type != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 24899, 25455);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 24899, 25455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 24899, 25455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNonGenericValueType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 25677, 26065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25760, 25800);

                var
                namedType = type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25814, 25897) || true) && (namedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 25814, 25897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25869, 25882);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 25814, 25897);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25911, 26016) || true) && (f_10176_25915_25938(namedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 25911, 26016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 25972, 26001);

                    return f_10176_25979_26000(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 25911, 26016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26030, 26054);

                return f_10176_26037_26053(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 25677, 26065);

                bool
                f_10176_25915_25938(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 25915, 25938);
                    return return_v;
                }


                bool
                f_10176_25979_26000(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 25979, 26000);
                    return return_v;
                }


                bool
                f_10176_26037_26053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 26037, 26053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 25677, 26065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 25677, 26065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 26077, 26217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26166, 26206);

                AddNullableTransforms(this, transforms);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 26077, 26217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 26077, 26217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 26077, 26217);
            }
        }

        private static void AddNullableTransforms(TypeWithAnnotations typeWithAnnotations, ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 26229, 27618);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26367, 27607) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26367, 27607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26412, 26448);

                        var
                        type = typeWithAnnotations.Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26468, 27244) || true) && (!IsNonGenericValueType(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26468, 27244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26542, 26598);

                            var
                            annotation = typeWithAnnotations.NullableAnnotation
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26620, 26630);

                            byte
                            flag
                            = default(byte);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26652, 27182) || true) && (f_10176_26656_26680(annotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 26656, 26700) || f_10176_26684_26700(type)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26652, 27182);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26750, 26810);

                                flag = NullableAnnotationExtensions.ObliviousAttributeValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26652, 27182);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26652, 27182);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26860, 27182) || true) && (f_10176_26864_26888(annotation))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26860, 27182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 26938, 26998);

                                    flag = NullableAnnotationExtensions.AnnotatedAttributeValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26860, 27182);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 26860, 27182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27096, 27159);

                                    flag = NullableAnnotationExtensions.NotAnnotatedAttributeValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26860, 27182);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26652, 27182);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27204, 27225);

                            f_10176_27204_27224(transforms, flag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26468, 27244);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27264, 27428) || true) && (f_10176_27268_27281(type) != TypeKind.Array)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 27264, 27428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27341, 27380);

                            f_10176_27341_27379(type, transforms);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27402, 27409);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 27264, 27428);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27519, 27592);

                        typeWithAnnotations = f_10176_27541_27591(((ArrayTypeSymbol)type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 26367, 27607);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10176, 26367, 27607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10176, 26367, 27607);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 26229, 27618);

                bool
                f_10176_26656_26680(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 26656, 26680);
                    return return_v;
                }


                bool
                f_10176_26684_26700(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 26684, 26700);
                    return return_v;
                }


                bool
                f_10176_26864_26888(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 26864, 26888);
                    return return_v;
                }


                int
                f_10176_27204_27224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, byte
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 27204, 27224);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10176_27268_27281(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 27268, 27281);
                    return return_v;
                }


                int
                f_10176_27341_27379(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                transforms)
                {
                    this_param.AddNullableTransforms(transforms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 27341, 27379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10176_27541_27591(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 27541, 27591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 26229, 27618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 26229, 27618);
            }
        }

        public bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeWithAnnotations result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 27630, 30004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27800, 27814);

                result = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27830, 27862);

                TypeSymbol
                oldTypeSymbol = Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 27876, 27895);

                byte
                transformFlag
                = default(byte);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28029, 28534) || true) && (IsNonGenericValueType(oldTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28029, 28534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28103, 28172);

                    transformFlag = NullableAnnotationExtensions.ObliviousAttributeValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28029, 28534);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28029, 28534);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28206, 28534) || true) && (transforms.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28206, 28534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28264, 28301);

                        transformFlag = defaultTransformFlag;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28206, 28534);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28206, 28534);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28335, 28534) || true) && (position < transforms.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28335, 28534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28401, 28440);

                            transformFlag = transforms[position++];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28335, 28534);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28335, 28534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28506, 28519);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28335, 28534);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28206, 28534);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28029, 28534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28550, 28575);

                TypeSymbol
                newTypeSymbol
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28589, 28760) || true) && (!f_10176_28594_28698(oldTypeSymbol, defaultTransformFlag, transforms, ref position, out newTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28589, 28760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28732, 28745);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28589, 28760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28776, 28943) || true) && ((object)oldTypeSymbol != newTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28776, 28943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28852, 28928);

                    result = result.WithTypeAndModifiers(newTypeSymbol, result.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28776, 28943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 28959, 29965);

                switch (transformFlag)
                {

                    case NullableAnnotationExtensions.AnnotatedAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28959, 29965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29094, 29136);

                        result = result.AsNullableReferenceType();
                        DynAbs.Tracing.TraceSender.TraceBreak(10176, 29158, 29164);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28959, 29965);

                    case NullableAnnotationExtensions.NotAnnotatedAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28959, 29965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29267, 29312);

                        result = result.AsNotNullableReferenceType();
                        DynAbs.Tracing.TraceSender.TraceBreak(10176, 29334, 29340);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28959, 29965);

                    case NullableAnnotationExtensions.ObliviousAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28959, 29965);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29440, 29823) || true) && (result.NullableAnnotation != NullableAnnotation.Oblivious && (DynAbs.Tracing.TraceSender.Expression_True(10176, 29444, 29606) && !(f_10176_29532_29571(result.NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 29532, 29605) && f_10176_29575_29605(oldTypeSymbol)))))
                        ) // Preserve nullable annotation on Nullable<T>.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 29440, 29823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29704, 29800);

                            result = CreateNonLazyType(newTypeSymbol, NullableAnnotation.Oblivious, result.CustomModifiers);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 29440, 29823);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10176, 29845, 29851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28959, 29965);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 28959, 29965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29901, 29915);

                        result = this;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29937, 29950);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 28959, 29965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 29981, 29993);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 27630, 30004);

                bool
                f_10176_28594_28698(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, byte
                defaultTransformFlag, System.Collections.Immutable.ImmutableArray<byte>
                transforms, ref int
                position, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                result)
                {
                    var return_v = this_param.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 28594, 28698);
                    return return_v;
                }


                bool
                f_10176_29532_29571(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 29532, 29571);
                    return return_v;
                }


                bool
                f_10176_29575_29605(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 29575, 29605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 27630, 30004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 27630, 30004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations WithTopLevelNonNullability()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 30016, 30406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30096, 30118);

                var
                typeSymbol = Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30132, 30292) || true) && (f_10176_30136_30171(NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 30136, 30231) || (f_10176_30176_30198(typeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 30176, 30230) && !f_10176_30203_30230(typeSymbol)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 30132, 30292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30265, 30277);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 30132, 30292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30308, 30395);

                return CreateNonLazyType(typeSymbol, NullableAnnotation.NotAnnotated, CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 30016, 30406);

                bool
                f_10176_30136_30171(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsNotAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 30136, 30171);
                    return return_v;
                }


                bool
                f_10176_30176_30198(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 30176, 30198);
                    return return_v;
                }


                bool
                f_10176_30203_30230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 30203, 30230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 30016, 30406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 30016, 30406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations SetUnknownNullabilityForReferenceTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 30418, 31115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30510, 30532);

                var
                typeSymbol = Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30546, 30618);

                var
                newTypeSymbol = f_10176_30566_30617(typeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30634, 30912) || true) && (NullableAnnotation != NullableAnnotation.Oblivious)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 30634, 30912);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30722, 30897) || true) && (f_10176_30726_30749_M(!typeSymbol.IsValueType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 30722, 30897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30791, 30878);

                        return CreateNonLazyType(newTypeSymbol, NullableAnnotation.Oblivious, CustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 30722, 30897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 30634, 30912);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 30928, 31076) || true) && ((object)newTypeSymbol != typeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 30928, 31076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31001, 31061);

                    return WithTypeAndModifiers(newTypeSymbol, CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 30928, 31076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31092, 31104);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 30418, 31115);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10176_30566_30617(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SetUnknownNullabilityForReferenceTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 30566, 30617);
                    return return_v;
                }


                bool
                f_10176_30726_30749_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 30726, 30749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 30418, 31115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 30418, 31115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Unsupported", error: true)]
        public override bool Equals(object other)
        {
            try
#pragma warning restore CS0809
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 31159, 31491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31388, 31480);

                return other is TypeWithAnnotations t && (DynAbs.Tracing.TraceSender.Expression_True(10176, 31395, 31479) && this.Equals(t, TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 31159, 31491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 31159, 31491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 31159, 31491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Unsupported", error: true)]
        public override int GetHashCode()
        {
            try
#pragma warning restore CS0809
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 31535, 31794);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31673, 31743) || true) && (f_10176_31677_31685_M(!HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 31673, 31743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31719, 31728);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 31673, 31743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 31757, 31783);

                return f_10176_31764_31782(Type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 31535, 31794);

                bool
                f_10176_31677_31685_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 31677, 31685);
                    return return_v;
                }


                int
                f_10176_31764_31782(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 31764, 31782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 31535, 31794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 31535, 31794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(TypeWithAnnotations? x, TypeWithAnnotations? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 31930, 32150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 32033, 32139);

                return x.HasValue == y.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(10176, 32040, 32138) && (f_10176_32069_32080_M(!x.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(10176, 32069, 32137) || x.GetValueOrDefault().IsSameAs(y.GetValueOrDefault()))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 31930, 32150);

                bool
                f_10176_32069_32080_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 32069, 32080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 31930, 32150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 31930, 32150);
            }
        }

        public static bool operator !=(TypeWithAnnotations? x, TypeWithAnnotations? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 32286, 32417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 32389, 32406);

                return !(x == y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 32286, 32417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 32286, 32417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 32286, 32417);
            }
        }

        internal bool IsSameAs(TypeWithAnnotations other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 32469, 32744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 32543, 32733);

                return f_10176_32550_32597(DefaultType, other.DefaultType) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 32550, 32664) && NullableAnnotation == other.NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 32550, 32732) && f_10176_32685_32732(_extensions, other._extensions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 32469, 32744);

                bool
                f_10176_32550_32597(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 32550, 32597);
                    return return_v;
                }


                bool
                f_10176_32685_32732(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 32685, 32732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 32469, 32744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 32469, 32744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithState ToTypeWithState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 32878, 34610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33332, 33406);

                return TypeWithState.Create(Type, getFlowState(Type, NullableAnnotation));

                static NullableFlowState getFlowState(TypeSymbol type, NullableAnnotation annotation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 33422, 34599);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33540, 33710) || true) && (type is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 33540, 33710);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33598, 33691);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 33605, 33629) || ((f_10176_33605_33629(annotation) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 33632, 33662)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 33665, 33690))) ? NullableFlowState.MaybeDefault : NullableFlowState.NotNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 33540, 33710);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33728, 34032) || true) && (f_10176_33732_33783(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 33728, 34032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33825, 34013);

                            return annotation switch
                            {
                                NullableAnnotation.Annotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33852, 33914) && DynAbs.Tracing.TraceSender.Expression_True(10176, 33852, 33914))
     => NullableFlowState.MaybeDefault,
                                NullableAnnotation.NotAnnotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33916, 33978) && DynAbs.Tracing.TraceSender.Expression_True(10176, 33916, 33978))
=> NullableFlowState.MaybeNull,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 33980, 34010) && DynAbs.Tracing.TraceSender.Expression_True(10176, 33980, 34010))
=> NullableFlowState.NotNull
                            };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 33728, 34032);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34050, 34291) || true) && (f_10176_34054_34106(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 34050, 34291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34148, 34272);

                            return annotation switch
                            {
                                NullableAnnotation.Annotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34175, 34237) && DynAbs.Tracing.TraceSender.Expression_True(10176, 34175, 34237))
     => NullableFlowState.MaybeDefault,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34239, 34269) && DynAbs.Tracing.TraceSender.Expression_True(10176, 34239, 34269))
=> NullableFlowState.NotNull
                            };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 34050, 34291);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34309, 34445) || true) && (f_10176_34313_34349(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 34309, 34445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34391, 34426);

                            return NullableFlowState.MaybeNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 34309, 34445);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34463, 34584);

                        return annotation switch
                        {
                            NullableAnnotation.Annotated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34490, 34549) && DynAbs.Tracing.TraceSender.Expression_True(10176, 34490, 34549))
 => NullableFlowState.MaybeNull,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34551, 34581) && DynAbs.Tracing.TraceSender.Expression_True(10176, 34551, 34581))
=> NullableFlowState.NotNull
                        };
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 33422, 34599);

                        bool
                        f_10176_33605_33629(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                        annotation)
                        {
                            var return_v = annotation.IsAnnotated();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 33605, 33629);
                            return return_v;
                        }


                        bool
                        f_10176_33732_33783(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsPossiblyNullableReferenceTypeTypeParameter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 33732, 33783);
                            return return_v;
                        }


                        bool
                        f_10176_34054_34106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 34054, 34106);
                            return return_v;
                        }


                        bool
                        f_10176_34313_34349(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableTypeOrTypeParameter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 34313, 34349);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 33422, 34599);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 33422, 34599);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 32878, 34610);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 32878, 34610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 32878, 34610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private abstract class Extensions
        {
            internal static readonly Extensions Default;

            internal static Extensions Create(ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 34938, 35228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 35052, 35155) || true) && (customModifiers.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 35052, 35155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 35121, 35136);

                        return Default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 35052, 35155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 35173, 35213);

                    return f_10176_35180_35212(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 34938, 35228);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.NonLazyType
                    f_10176_35180_35212(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    customModifiers)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.NonLazyType(customModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 35180, 35212);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 34938, 35228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 34938, 35228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static Extensions CreateLazy(CSharpCompilation compilation, TypeWithAnnotations underlying)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10176, 35244, 35454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 35377, 35439);

                    return f_10176_35384_35438(compilation, underlying);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10176, 35244, 35454);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter
                    f_10176_35384_35438(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlying)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter(compilation, underlying);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 35384, 35438);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 35244, 35454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 35244, 35454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal abstract bool IsResolved { get; }

            internal abstract TypeSymbol GetResolvedType(TypeSymbol defaultType);

            internal abstract ImmutableArray<CustomModifier> CustomModifiers { get; }

            internal abstract TypeWithAnnotations AsNullableReferenceType(TypeWithAnnotations type);

            internal abstract TypeWithAnnotations AsNotNullableReferenceType(TypeWithAnnotations type);

            internal abstract TypeWithAnnotations WithModifiers(TypeWithAnnotations type, ImmutableArray<CustomModifier> customModifiers);

            internal abstract TypeSymbol GetNullableUnderlyingTypeOrSelf(TypeSymbol typeSymbol);

            internal abstract TypeSymbol AsTypeSymbolOnly(TypeSymbol typeSymbol);

            internal abstract SpecialType GetSpecialType(TypeSymbol typeSymbol);

            internal abstract bool IsRestrictedType(TypeSymbol typeSymbol, bool ignoreSpanLikeTypes);

            internal abstract bool IsStatic(TypeSymbol typeSymbol);

            internal abstract bool IsVoid(TypeSymbol typeSymbol);

            internal abstract bool IsSZArray(TypeSymbol typeSymbol);

            internal abstract TypeWithAnnotations WithTypeAndModifiers(TypeWithAnnotations type, TypeSymbol typeSymbol, ImmutableArray<CustomModifier> customModifiers);

            internal abstract bool TypeSymbolEquals(TypeWithAnnotations type, TypeWithAnnotations other, TypeCompareKind comparison);

            internal abstract TypeWithAnnotations SubstituteType(TypeWithAnnotations type, AbstractTypeMap typeMap);

            internal abstract void ReportDiagnosticsIfObsolete(TypeWithAnnotations type, Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics);

            internal abstract void TryForceResolve(bool asValueType);

            public Extensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 34747, 37274);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 34747, 37274);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 34747, 37274);
            }


            static Extensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 34747, 37274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 34841, 34921);
                Default = f_10176_34851_34921(customModifiers: ImmutableArray<CustomModifier>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 34747, 37274);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 34747, 37274);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10176, 34747, 37274);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.NonLazyType
            f_10176_34851_34921(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            customModifiers)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.NonLazyType(customModifiers: customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 34851, 34921);
                return return_v;
            }

        }
        private sealed class NonLazyType : Extensions
        {
            private readonly ImmutableArray<CustomModifier> _customModifiers;

            public NonLazyType(ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 37437, 37645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37536, 37577);

                    f_10176_37536_37576(f_10176_37549_37575_M(!customModifiers.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37595, 37630);

                    _customModifiers = customModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 37437, 37645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 37437, 37645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37437, 37645);
                }
            }

            internal override bool IsResolved
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 37695, 37702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37698, 37702);
                        return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 37695, 37702);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 37695, 37702);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37695, 37702);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TypeSymbol GetResolvedType(TypeSymbol defaultType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 37786, 37800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37789, 37800);
                    return defaultType; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 37786, 37800);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 37786, 37800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37786, 37800);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<CustomModifier> CustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 37880, 37899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37883, 37899);
                        return _customModifiers; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 37880, 37899);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 37880, 37899);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37880, 37899);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType GetSpecialType(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 37984, 38009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 37987, 38009);
                    return f_10176_37987_38009(typeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 37984, 38009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 37984, 38009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37984, 38009);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.SpecialType
                f_10176_37987_38009(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 37987, 38009);
                    return return_v;
                }

            }

            internal override bool IsRestrictedType(TypeSymbol typeSymbol, bool ignoreSpanLikeTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38113, 38164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38116, 38164);
                    return f_10176_38116_38164(typeSymbol, ignoreSpanLikeTypes); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38113, 38164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38113, 38164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38113, 38164);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10176_38116_38164(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                ignoreSpanLikeTypes)
                {
                    var return_v = type.IsRestrictedType(ignoreSpanLikeTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 38116, 38164);
                    return return_v;
                }

            }

            internal override bool IsStatic(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38234, 38256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38237, 38256);
                    return f_10176_38237_38256(typeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38234, 38256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38234, 38256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38234, 38256);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10176_38237_38256(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 38237, 38256);
                    return return_v;
                }

            }

            internal override bool IsVoid(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38324, 38350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38327, 38350);
                    return f_10176_38327_38350(typeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38324, 38350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38324, 38350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38324, 38350);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10176_38327_38350(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 38327, 38350);
                    return return_v;
                }

            }

            internal override bool IsSZArray(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38421, 38446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38424, 38446);
                    return f_10176_38424_38446(typeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38421, 38446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38421, 38446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38421, 38446);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10176_38424_38446(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsSZArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 38424, 38446);
                    return return_v;
                }

            }

            internal override TypeSymbol GetNullableUnderlyingTypeOrSelf(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38547, 38575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38550, 38575);
                    return f_10176_38550_38575(typeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38547, 38575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38547, 38575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38547, 38575);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10176_38550_38575(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 38550, 38575);
                    return return_v;
                }

            }

            internal override TypeWithAnnotations WithModifiers(TypeWithAnnotations type, ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38592, 38850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38750, 38835);

                    return CreateNonLazyType(type.DefaultType, type.NullableAnnotation, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38592, 38850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38592, 38850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38592, 38850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeSymbol AsTypeSymbolOnly(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38935, 38948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 38938, 38948);
                    return typeSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38935, 38948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38935, 38948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38935, 38948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations WithTypeAndModifiers(TypeWithAnnotations type, TypeSymbol typeSymbol, ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 38965, 39247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 39153, 39232);

                    return CreateNonLazyType(typeSymbol, type.NullableAnnotation, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 38965, 39247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 38965, 39247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 38965, 39247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations AsNullableReferenceType(TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 39263, 39489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 39383, 39474);

                    return CreateNonLazyType(type.DefaultType, NullableAnnotation.Annotated, _customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 39263, 39489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 39263, 39489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 39263, 39489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations AsNotNullableReferenceType(TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 39505, 39842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 39628, 39663);

                    var
                    defaultType = type.DefaultType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 39681, 39827);

                    return CreateNonLazyType(defaultType, (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 39719, 39747) || ((f_10176_39719_39747(defaultType) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 39750, 39773)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 39776, 39807))) ? type.NullableAnnotation : NullableAnnotation.NotAnnotated, _customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 39505, 39842);

                    bool
                    f_10176_39719_39747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 39719, 39747);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 39505, 39842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 39505, 39842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool TypeSymbolEquals(TypeWithAnnotations type, TypeWithAnnotations other, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 39858, 40078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 40011, 40063);

                    return type.TypeSymbolEqualsCore(other, comparison);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 39858, 40078);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 39858, 40078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 39858, 40078);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations SubstituteType(TypeWithAnnotations type, AbstractTypeMap typeMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 40094, 40285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 40230, 40270);

                    return type.SubstituteTypeCore(typeMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 40094, 40285);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 40094, 40285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 40094, 40285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void ReportDiagnosticsIfObsolete(TypeWithAnnotations type, Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 40301, 40552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 40471, 40537);

                    type.ReportDiagnosticsIfObsoleteCore(binder, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 40301, 40552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 40301, 40552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 40301, 40552);
                }
            }

            internal override void TryForceResolve(bool asValueType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 40568, 40654);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 40568, 40654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 40568, 40654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 40568, 40654);
                }
            }

            static NonLazyType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 37286, 40665);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 37286, 40665);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 37286, 40665);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10176, 37286, 40665);

            bool
            f_10176_37549_37575_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 37549, 37575);
                return return_v;
            }


            int
            f_10176_37536_37576(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 37536, 37576);
                return 0;
            }

        }
        private sealed class LazyNullableTypeParameter : Extensions
        {
            private readonly CSharpCompilation _compilation;

            private readonly TypeWithAnnotations _underlying;

            private TypeSymbol _resolved;

            public LazyNullableTypeParameter(CSharpCompilation compilation, TypeWithAnnotations underlying)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10176, 41117, 41552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 40982, 40994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41091, 41100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41245, 41304);

                    f_10176_41245_41303(!f_10176_41259_41302(underlying.NullableAnnotation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41322, 41382);

                    f_10176_41322_41381(underlying.TypeKind == TypeKind.TypeParameter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41400, 41449);

                    f_10176_41400_41448(underlying.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41467, 41494);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41512, 41537);

                    _underlying = underlying;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10176, 41117, 41552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 41117, 41552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 41117, 41552);
                }
            }

            internal override bool IsVoid(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 41621, 41629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41624, 41629);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 41621, 41629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 41621, 41629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 41621, 41629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsSZArray(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 41700, 41708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41703, 41708);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 41700, 41708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 41700, 41708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 41700, 41708);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsStatic(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 41778, 41786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41781, 41786);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 41778, 41786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 41778, 41786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 41778, 41786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeSymbol GetResolvedType()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 41803, 42141);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41872, 42089) || true) && ((object)_resolved == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 41872, 42089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 41943, 41987);

                        f_10176_41943_41986(_underlying.IsSafeToResolve());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42011, 42070);

                        f_10176_42011_42069(this, asValueType: f_10176_42040_42068(_underlying.Type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 41872, 42089);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42109, 42126);

                    return _resolved;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 41803, 42141);

                    int
                    f_10176_41943_41986(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 41943, 41986);
                        return 0;
                    }


                    bool
                    f_10176_42040_42068(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 42040, 42068);
                        return return_v;
                    }


                    int
                    f_10176_42011_42069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter
                    this_param, bool
                    asValueType)
                    {
                        this_param.TryForceResolve(asValueType: asValueType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 42011, 42069);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 41803, 42141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 41803, 42141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeSymbol GetNullableUnderlyingTypeOrSelf(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 42241, 42260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42244, 42260);
                    return _underlying.Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 42241, 42260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 42241, 42260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 42241, 42260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SpecialType GetSpecialType(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 42277, 42518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42377, 42419);

                    var
                    specialType = _underlying.SpecialType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42437, 42503);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 42444, 42469) || ((f_10176_42444_42469(specialType) && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 42472, 42488)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 42491, 42502))) ? SpecialType.None : specialType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 42277, 42518);

                    bool
                    f_10176_42444_42469(Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = specialType.IsValueType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 42444, 42469);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 42277, 42518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 42277, 42518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsRestrictedType(TypeSymbol typeSymbol, bool ignoreSpanLikeTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 42623, 42675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42626, 42675);
                    return _underlying.IsRestrictedType(ignoreSpanLikeTypes); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 42623, 42675);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 42623, 42675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 42623, 42675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeSymbol AsTypeSymbolOnly(TypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 42692, 42972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42793, 42830);

                    var
                    resolvedType = f_10176_42812_42829(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42848, 42919);

                    f_10176_42848_42918(f_10176_42861_42890(resolvedType) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 42861, 42917) && f_10176_42894_42909().IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 42937, 42957);

                    return resolvedType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 42692, 42972);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10176_42812_42829(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter
                    this_param)
                    {
                        var return_v = this_param.GetResolvedType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 42812, 42829);
                        return return_v;
                    }


                    bool
                    f_10176_42861_42890(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 42861, 42890);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10176_42894_42909()
                    {
                        var return_v = CustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 42894, 42909);
                        return return_v;
                    }


                    int
                    f_10176_42848_42918(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 42848, 42918);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 42692, 42972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 42692, 42972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsResolved
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 43022, 43050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43025, 43050);
                        return (object)_resolved != null; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 43022, 43050);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 43022, 43050);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 43022, 43050);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TypeSymbol GetResolvedType(TypeSymbol defaultType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 43134, 43154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43137, 43154);
                    return f_10176_43137_43154(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 43134, 43154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 43134, 43154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 43134, 43154);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10176_43137_43154(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter
                this_param)
                {
                    var return_v = this_param.GetResolvedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 43137, 43154);
                    return return_v;
                }

            }

            internal override ImmutableArray<CustomModifier> CustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 43234, 43273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43237, 43273);
                        return ImmutableArray<CustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 43234, 43273);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 43234, 43273);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 43234, 43273);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TypeWithAnnotations WithModifiers(TypeWithAnnotations type, ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 43290, 43940);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43448, 43548) || true) && (customModifiers.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 43448, 43548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43517, 43529);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 43448, 43548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43568, 43605);

                    var
                    resolvedType = f_10176_43587_43604(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43623, 43824) || true) && (f_10176_43627_43656(resolvedType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 43623, 43824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43698, 43805);

                        return TypeWithAnnotations.Create(resolvedType, type.NullableAnnotation, customModifiers: customModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 43623, 43824);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 43844, 43925);

                    return CreateNonLazyType(resolvedType, type.NullableAnnotation, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 43290, 43940);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10176_43587_43604(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.LazyNullableTypeParameter
                    this_param)
                    {
                        var return_v = this_param.GetResolvedType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 43587, 43604);
                        return return_v;
                    }


                    bool
                    f_10176_43627_43656(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 43627, 43656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 43290, 43940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 43290, 43940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations WithTypeAndModifiers(TypeWithAnnotations type, TypeSymbol typeSymbol, ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 43956, 44455);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44144, 44341) || true) && (f_10176_44148_44175(typeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 44144, 44341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44217, 44322);

                        return TypeWithAnnotations.Create(typeSymbol, type.NullableAnnotation, customModifiers: customModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 44144, 44341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44361, 44440);

                    return CreateNonLazyType(typeSymbol, type.NullableAnnotation, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 43956, 44455);

                    bool
                    f_10176_44148_44175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 44148, 44175);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 43956, 44455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 43956, 44455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations AsNullableReferenceType(TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 44471, 44618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44591, 44603);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 44471, 44618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 44471, 44618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 44471, 44618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations AsNotNullableReferenceType(TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 44634, 44915);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44757, 44870) || true) && (f_10176_44761_44790_M(!_underlying.Type.IsValueType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 44757, 44870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44832, 44851);

                        return _underlying;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 44757, 44870);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 44888, 44900);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 44634, 44915);

                    bool
                    f_10176_44761_44790_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 44761, 44790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 44634, 44915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 44634, 44915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeWithAnnotations SubstituteType(TypeWithAnnotations type, AbstractTypeMap typeMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 44931, 45915);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45067, 45197) || true) && ((object)_resolved != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 45067, 45197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45138, 45178);

                        return type.SubstituteTypeCore(typeMap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 45067, 45197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45217, 45277);

                    var
                    newUnderlying = _underlying.SubstituteTypeCore(typeMap)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45295, 45900) || true) && (!newUnderlying.IsSameAs(this._underlying))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 45295, 45900);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45382, 45668) || true) && (f_10176_45386_45470(newUnderlying.Type, this._underlying.Type, TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10176, 45386, 45536) && newUnderlying.CustomModifiers.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 45382, 45668);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45586, 45645);

                            return CreateLazyNullableType(_compilation, newUnderlying);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 45382, 45668);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45692, 45732);

                        return type.SubstituteTypeCore(typeMap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 45295, 45900);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 45295, 45900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 45814, 45826);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 45295, 45900);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 44931, 45915);

                    bool
                    f_10176_45386_45470(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 45386, 45470);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 44931, 45915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 44931, 45915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void ReportDiagnosticsIfObsolete(TypeWithAnnotations type, Binder binder, SyntaxNode syntax, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 45931, 46477);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46101, 46462) || true) && ((object)_resolved != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 46101, 46462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46172, 46238);

                        type.ReportDiagnosticsIfObsoleteCore(binder, syntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 46101, 46462);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 46101, 46462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46320, 46443);

                        f_10176_46320_46442(diagnostics, f_10176_46336_46419(type, f_10176_46373_46404(binder), binder.Flags), f_10176_46421_46441(syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 46101, 46462);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 45931, 46477);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10176_46373_46404(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 46373, 46404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LazyObsoleteDiagnosticInfo
                    f_10176_46336_46419(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
                    containingSymbol, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    binderFlags)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LazyObsoleteDiagnosticInfo((object)symbol, containingSymbol, binderFlags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 46336, 46419);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10176_46421_46441(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 46421, 46441);
                        return return_v;
                    }


                    int
                    f_10176_46320_46442(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.LazyObsoleteDiagnosticInfo
                    info, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 46320, 46442);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 45931, 46477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 45931, 46477);
                }
            }

            internal override bool TypeSymbolEquals(TypeWithAnnotations type, TypeWithAnnotations other, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 46493, 46977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46646, 46709);

                    var
                    otherLazy = other._extensions as LazyNullableTypeParameter
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46729, 46890) || true) && ((object)otherLazy != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10176, 46729, 46890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46800, 46871);

                        return _underlying.TypeSymbolEquals(otherLazy._underlying, comparison);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10176, 46729, 46890);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 46910, 46962);

                    return type.TypeSymbolEqualsCore(other, comparison);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 46493, 46977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 46493, 46977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 46493, 46977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void TryForceResolve(bool asValueType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10176, 46993, 47369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 47082, 47277);

                    var
                    resolved = (DynAbs.Tracing.TraceSender.Conditional_F1(10176, 47097, 47108) || ((asValueType && DynAbs.Tracing.TraceSender.Conditional_F2(10176, 47132, 47236)) || DynAbs.Tracing.TraceSender.Conditional_F3(10176, 47260, 47276))) ? f_10176_47132_47236(f_10176_47132_47190(_compilation, SpecialType.System_Nullable_T), f_10176_47201_47235(_underlying)) : _underlying.Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 47295, 47354);

                    f_10176_47295_47353(ref _resolved, resolved, null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10176, 46993, 47369);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10176_47132_47190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 47132, 47190);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10176_47201_47235(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 47201, 47235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10176_47132_47236(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 47132, 47236);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10176_47295_47353(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 47295, 47353);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10176, 46993, 47369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 46993, 47369);
                }
            }

            static LazyNullableTypeParameter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 40863, 47380);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 40863, 47380);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 40863, 47380);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10176, 40863, 47380);

            bool
            f_10176_41259_41302(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
            annotation)
            {
                var return_v = annotation.IsAnnotated();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 41259, 41302);
                return return_v;
            }


            int
            f_10176_41245_41303(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 41245, 41303);
                return 0;
            }


            int
            f_10176_41322_41381(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 41322, 41381);
                return 0;
            }


            int
            f_10176_41400_41448(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 41400, 41448);
                return 0;
            }

        }
        static TypeWithAnnotations()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10176, 618, 47387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2335, 2734);
            DebuggerDisplayFormat = f_10176_2359_2734(typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, miscellaneousOptions: SymbolDisplayMiscellaneousOptions.UseSpecialTypes | SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10176, 2792, 3263);
            TestDisplayFormat = f_10176_2812_3263(typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters, miscellaneousOptions: SymbolDisplayMiscellaneousOptions.UseSpecialTypes | SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier | SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10176, 618, 47387);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10176, 618, 47387);
        }

        static bool
        f_10176_1860_1888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        type)
        {
            var return_v = type.IsNullableType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 1860, 1888);
            return return_v;
        }


        static int
        f_10176_1984_2020(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 1984, 2020);
            return 0;
        }


        static int
        f_10176_2035_2067(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 2035, 2067);
            return 0;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_10176_2359_2734(Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(typeQualificationStyle: typeQualificationStyle, genericsOptions: genericsOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 2359, 2734);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_10176_2812_3263(Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(typeQualificationStyle: typeQualificationStyle, genericsOptions: genericsOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 2812, 3263);
            return return_v;
        }


        bool?
        f_10176_10646_10669_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 10646, 10669);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10176_10715_10756_I(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10715, 10756);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10176_10817_10873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        typeSymbol)
        {
            var return_v = this_param.GetNullableUnderlyingTypeOrSelf(typeSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 10817, 10873);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10176_11480_11507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
        this_param)
        {
            var return_v = this_param.CustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 11480, 11507);
            return return_v;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10176_11548_11561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 11548, 11561);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10176_11606_11645(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        typeSymbol)
        {
            var return_v = this_param.GetSpecialType(typeSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 11606, 11645);
            return return_v;
        }


        Microsoft.Cci.PrimitiveTypeCode
        f_10176_11706_11728(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.PrimitiveTypeCode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10176, 11706, 11728);
            return return_v;
        }


        bool
        f_10176_11946_11979(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Extensions
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        typeSymbol)
        {
            var return_v = this_param.IsStatic(typeSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10176, 11946, 11979);
            return return_v;
        }

    }
}
