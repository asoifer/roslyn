// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedTypeParameterSymbol
            : TypeParameterSymbol
    {
        protected readonly TypeParameterSymbol _underlyingTypeParameter;

        public WrappedTypeParameterSymbol(TypeParameterSymbol underlyingTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10389, 1098, 1331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1061, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1201, 1255);

                f_10389_1201_1254((object)underlyingTypeParameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1269, 1320);

                _underlyingTypeParameter = underlyingTypeParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10389, 1098, 1331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 1098, 1331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 1098, 1331);
            }
        }

        public TypeParameterSymbol UnderlyingTypeParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 1418, 1501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1454, 1486);

                    return _underlyingTypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 1418, 1501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 1343, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 1343, 1512);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 1590, 1651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1596, 1649);

                    return f_10389_1603_1648(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 1590, 1651);

                    bool
                    f_10389_1603_1648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 1603, 1648);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 1524, 1662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 1524, 1662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 1750, 1851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1786, 1836);

                    return f_10389_1793_1835(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 1750, 1851);

                    Microsoft.CodeAnalysis.TypeParameterKind
                    f_10389_1793_1835(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameterKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 1793, 1835);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 1674, 1862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 1674, 1862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 1926, 2017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 1962, 2002);

                    return f_10389_1969_2001(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 1926, 2017);

                    int
                    f_10389_1969_2001(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 1969, 2001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 1874, 2028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 1874, 2028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 2110, 2218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 2146, 2203);

                    return f_10389_2153_2202(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 2110, 2218);

                    bool
                    f_10389_2153_2202(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 2153, 2202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 2040, 2229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 2040, 2229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 2313, 2423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 2349, 2408);

                    return f_10389_2356_2407(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 2313, 2423);

                    bool
                    f_10389_2356_2407(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 2356, 2407);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 2241, 2434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 2241, 2434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 2526, 2728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 2562, 2713);

                    return f_10389_2569_2628(_underlyingTypeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10389, 2569, 2712) || f_10389_2632_2712(f_10389_2676_2711()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 2526, 2728);

                    bool
                    f_10389_2569_2628(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReferenceTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 2569, 2628);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10389_2676_2711()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 2676, 2711);
                        return return_v;
                    }


                    bool
                    f_10389_2632_2712(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsReferenceTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 2632, 2712);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 2446, 2739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 2446, 2739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 2833, 2950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 2869, 2935);

                    return f_10389_2876_2934(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 2833, 2950);

                    bool?
                    f_10389_2876_2934(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ReferenceTypeConstraintIsNullable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 2876, 2934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 2751, 2961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 2751, 2961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 3039, 3143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 3075, 3128);

                    return f_10389_3082_3127(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 3039, 3143);

                    bool
                    f_10389_3082_3127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasNotNullConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3082, 3127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 2973, 3154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 2973, 3154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 3238, 3348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 3274, 3333);

                    return f_10389_3281_3332(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 3238, 3348);

                    bool
                    f_10389_3281_3332(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3281, 3332);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 3166, 3359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 3166, 3359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 3439, 3545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 3475, 3530);

                    return f_10389_3482_3529(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 3439, 3545);

                    bool
                    f_10389_3482_3529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3482, 3529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 3371, 3556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 3371, 3556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 3644, 3838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 3680, 3823);

                    return f_10389_3687_3742(_underlyingTypeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10389, 3687, 3822) || f_10389_3746_3822(f_10389_3786_3821()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 3644, 3838);

                    bool
                    f_10389_3687_3742(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3687, 3742);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10389_3786_3821()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3786, 3821);
                        return return_v;
                    }


                    bool
                    f_10389_3746_3822(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsValueTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 3746, 3822);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 3568, 3849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 3568, 3849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 3923, 4015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 3959, 4000);

                    return f_10389_3966_3999(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 3923, 4015);

                    Microsoft.CodeAnalysis.VarianceKind
                    f_10389_3966_3999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Variance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 3966, 3999);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 3861, 4026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 3861, 4026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 4113, 4206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 4149, 4191);

                    return f_10389_4156_4190(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 4113, 4206);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10389_4156_4190(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 4156, 4190);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 4038, 4217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 4038, 4217);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 4327, 4436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 4363, 4421);

                    return f_10389_4370_4420(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 4327, 4436);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10389_4370_4420(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 4370, 4420);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 4229, 4447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 4229, 4447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 4511, 4599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 4547, 4584);

                    return f_10389_4554_4583(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 4511, 4599);

                    string
                    f_10389_4554_4583(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10389, 4554, 4583);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 4459, 4610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 4459, 4610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 4622, 4951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 4828, 4940);

                return f_10389_4835_4939(_underlyingTypeParameter, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 4622, 4951);

                string
                f_10389_4835_4939(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 4835, 4939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 4622, 4951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 4622, 4951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void EnsureAllConstraintsAreResolved()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 4963, 5114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 5044, 5103);

                f_10389_5044_5102(_underlyingTypeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 4963, 5114);

                int
                f_10389_5044_5102(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    this_param.EnsureAllConstraintsAreResolved();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 5044, 5102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 4963, 5114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 4963, 5114);
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10389, 5126, 5277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10389, 5218, 5266);

                return f_10389_5225_5265(_underlyingTypeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10389, 5126, 5277);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10389_5225_5265(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 5225, 5265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10389, 5126, 5277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 5126, 5277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WrappedTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10389, 778, 5284);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10389, 778, 5284);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10389, 778, 5284);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10389, 778, 5284);

        int
        f_10389_1201_1254(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10389, 1201, 1254);
            return 0;
        }

    }
}
