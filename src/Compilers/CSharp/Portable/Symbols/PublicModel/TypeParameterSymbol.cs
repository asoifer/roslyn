// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class TypeParameterSymbol : TypeSymbol, ITypeParameterSymbol
    {
        private readonly Symbols.TypeParameterSymbol _underlying;

        public TypeParameterSymbol(Symbols.TypeParameterSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10659_664_682_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10659, 525, 793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 501, 512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 708, 743);

                f_10659_708_742(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 757, 782);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10659, 525, 793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 525, 793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 525, 793);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 805, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 935, 1009);

                f_10659_935_1008(nullableAnnotation != f_10659_970_1007(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1023, 1083);

                f_10659_1023_1082(nullableAnnotation != f_10659_1058_1081(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1097, 1161);

                return f_10659_1104_1160(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 805, 1172);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10659_970_1007(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 970, 1007);
                    return return_v;
                }


                int
                f_10659_935_1008(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 935, 1008);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10659_1058_1081(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 1058, 1081);
                    return return_v;
                }


                int
                f_10659_1023_1082(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 1023, 1082);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                f_10659_1104_1160(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 1104, 1160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 805, 1172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 805, 1172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Symbols.TypeSymbol UnderlyingTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 1242, 1256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1245, 1256);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 1242, 1256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 1242, 1256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 1242, 1256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 1316, 1330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1319, 1330);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 1316, 1330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 1316, 1330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 1316, 1330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.NamespaceOrTypeSymbol UnderlyingNamespaceOrTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 1421, 1435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1424, 1435);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 1421, 1435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 1421, 1435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 1421, 1435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbols.TypeParameterSymbol UnderlyingTypeParameterSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 1513, 1527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1516, 1527);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 1513, 1527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 1513, 1527);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 1513, 1527);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation ITypeParameterSymbol.ReferenceTypeConstraintNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 1635, 2045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1651, 2045);
                    return f_10659_1651_1696(_underlying) switch
                    {
                        false when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1742, 1786) || true) && (f_10659_1747_1786_M(!_underlying.HasReferenceTypeConstraint)) && (DynAbs.Tracing.TraceSender.Expression_True(10659, 1742, 1786) || true)
        => CodeAnalysis.NullableAnnotation.None,
                        false when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1845, 1898) && DynAbs.Tracing.TraceSender.Expression_True(10659, 1845, 1898))
        => CodeAnalysis.NullableAnnotation.NotAnnotated,
                        true when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1917, 1966) && DynAbs.Tracing.TraceSender.Expression_True(10659, 1917, 1966))
        => CodeAnalysis.NullableAnnotation.Annotated,
                        null when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 1985, 2029) && DynAbs.Tracing.TraceSender.Expression_True(10659, 1985, 2029))
        => CodeAnalysis.NullableAnnotation.None,
                    }; DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 1635, 2045);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 1635, 2045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 1635, 2045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeParameterKind ITypeParameterSymbol.TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 2139, 2227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 2175, 2212);

                    return f_10659_2182_2211(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 2139, 2227);

                    Microsoft.CodeAnalysis.TypeParameterKind
                    f_10659_2182_2211(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameterKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 2182, 2211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 2058, 2238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 2058, 2238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol ITypeParameterSymbol.DeclaringMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 2325, 2386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 2331, 2384);

                    return f_10659_2338_2383(f_10659_2338_2365(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 2325, 2386);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10659_2338_2365(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 2338, 2365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10659_2338_2383(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 2338, 2383);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 2250, 2397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 2250, 2397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol ITypeParameterSymbol.DeclaringType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 2485, 2544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 2491, 2542);

                    return f_10659_2498_2541(f_10659_2498_2523(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 2485, 2544);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10659_2498_2523(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 2498, 2523);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10659_2498_2541(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 2498, 2541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 2409, 2555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 2409, 2555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ITypeSymbol> ITypeParameterSymbol.ConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 2656, 2781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 2692, 2766);

                    return _underlying.ConstraintTypesNoUseSiteDiagnostics.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 2656, 2781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 2567, 2792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 2567, 2792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CodeAnalysis.NullableAnnotation> ITypeParameterSymbol.ConstraintNullableAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 2903, 2988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 2919, 2988);
                    return _underlying.ConstraintTypesNoUseSiteDiagnostics.ToPublicAnnotations(); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 2903, 2988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 2903, 2988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 2903, 2988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeParameterSymbol ITypeParameterSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3086, 3150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3092, 3148);

                    return f_10659_3099_3147(f_10659_3099_3129(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3086, 3150);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10659_3099_3129(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3099, 3129);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeParameterSymbol?
                    f_10659_3099_3147(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 3099, 3147);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3001, 3161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3001, 3161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeParameterSymbol ITypeParameterSymbol.ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3251, 3308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3257, 3306);

                    return f_10659_3264_3305(f_10659_3264_3287(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3251, 3308);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10659_3264_3287(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ReducedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3264, 3287);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeParameterSymbol?
                    f_10659_3264_3305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 3264, 3305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3173, 3319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3173, 3319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int ITypeParameterSymbol.Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3364, 3386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3367, 3386);
                    return f_10659_3367_3386(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3364, 3386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3364, 3386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3364, 3386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        VarianceKind ITypeParameterSymbol.Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3442, 3465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3445, 3465);
                    return f_10659_3445_3465(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3442, 3465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3442, 3465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3442, 3465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeParameterSymbol.HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3531, 3572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3534, 3572);
                    return f_10659_3534_3572(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3531, 3572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3531, 3572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3531, 3572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeParameterSymbol.HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3634, 3671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3637, 3671);
                    return f_10659_3637_3671(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3634, 3671);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3634, 3671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3634, 3671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeParameterSymbol.HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3737, 3778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3740, 3778);
                    return f_10659_3740_3778(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3737, 3778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3737, 3778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3737, 3778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeParameterSymbol.HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3838, 3873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3841, 3873);
                    return f_10659_3841_3873(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3838, 3873);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3838, 3873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3838, 3873);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeParameterSymbol.HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 3937, 3976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 3940, 3976);
                    return f_10659_3940_3976(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 3937, 3976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 3937, 3976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 3937, 3976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 4024, 4146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 4102, 4135);

                f_10659_4102_4134(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 4024, 4146);

                int
                f_10659_4102_4134(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                symbol)
                {
                    this_param.VisitTypeParameter((Microsoft.CodeAnalysis.ITypeParameterSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 4102, 4134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 4024, 4146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 4024, 4146);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10659, 4158, 4308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10659, 4257, 4297);

                return f_10659_4264_4296<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10659, 4158, 4308);

                TResult?
                f_10659_4264_4296<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                symbol)
                {
                    var return_v = this_param.VisitTypeParameter((Microsoft.CodeAnalysis.ITypeParameterSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 4264, 4296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10659, 4158, 4308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 4158, 4308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10659, 363, 4337);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10659, 363, 4337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10659, 363, 4337);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10659, 363, 4337);

        int
        f_10659_708_742(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10659, 708, 742);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10659_664_682_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10659, 525, 793);
            return return_v;
        }


        bool?
        f_10659_1651_1696(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.ReferenceTypeConstraintIsNullable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 1651, 1696);
            return return_v;
        }


        bool
        f_10659_1747_1786_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 1747, 1786);
            return return_v;
        }


        int
        f_10659_3367_3386(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3367, 3386);
            return return_v;
        }


        Microsoft.CodeAnalysis.VarianceKind
        f_10659_3445_3465(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.Variance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3445, 3465);
            return return_v;
        }


        bool
        f_10659_3534_3572(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.HasReferenceTypeConstraint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3534, 3572);
            return return_v;
        }


        bool
        f_10659_3637_3671(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.HasValueTypeConstraint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3637, 3671);
            return return_v;
        }


        bool
        f_10659_3740_3778(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.HasUnmanagedTypeConstraint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3740, 3778);
            return return_v;
        }


        bool
        f_10659_3841_3873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.HasNotNullConstraint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3841, 3873);
            return return_v;
        }


        bool
        f_10659_3940_3976(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.HasConstructorConstraint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10659, 3940, 3976);
            return return_v;
        }

    }
}
