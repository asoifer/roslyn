// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedNamedTypeSymbol : NamedTypeSymbol
    {
        protected readonly NamedTypeSymbol _underlyingType;

        public WrappedNamedTypeSymbol(NamedTypeSymbol underlyingType, TupleExtraData tupleData)
        : base(f_10386_1188_1197_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10386, 1080, 1326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1052, 1067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1223, 1268);

                f_10386_1223_1267((object)underlyingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1282, 1315);

                _underlyingType = underlyingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10386, 1080, 1326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1080, 1326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1080, 1326);
            }
        }

        public NamedTypeSymbol UnderlyingNamedType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 1405, 1479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1441, 1464);

                    return _underlyingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 1405, 1479);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1338, 1490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1338, 1490);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 1568, 1620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1574, 1618);

                    return f_10386_1581_1617(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 1568, 1620);

                    bool
                    f_10386_1581_1617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 1581, 1617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1502, 1631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1502, 1631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 1693, 1773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1729, 1758);

                    return f_10386_1736_1757(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 1693, 1773);

                    int
                    f_10386_1736_1757(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 1736, 1757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1643, 1784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1643, 1784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 1870, 1973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 1906, 1958);

                    return f_10386_1913_1957(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 1870, 1973);

                    bool
                    f_10386_1913_1957(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MightContainExtensionMethods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 1913, 1957);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1796, 1984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1796, 1984);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 2048, 2127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 2084, 2112);

                    return f_10386_2091_2111(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 2048, 2127);

                    string
                    f_10386_2091_2111(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 2091, 2111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 1996, 2138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 1996, 2138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 2210, 2297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 2246, 2282);

                    return f_10386_2253_2281(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 2210, 2297);

                    string
                    f_10386_2253_2281(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 2253, 2281);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 2150, 2308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 2150, 2308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 2382, 2471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 2418, 2456);

                    return f_10386_2425_2455(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 2382, 2471);

                    bool
                    f_10386_2425_2455(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 2425, 2455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 2320, 2482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 2320, 2482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 2552, 2637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 2588, 2622);

                    return f_10386_2595_2621(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 2552, 2637);

                    bool
                    f_10386_2595_2621(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MangleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 2595, 2621);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 2494, 2648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 2494, 2648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 2660, 2980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 2866, 2969);

                return f_10386_2873_2968(_underlyingType, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 2660, 2980);

                string
                f_10386_2873_2968(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 2873, 2968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 2660, 2980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 2660, 2980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 3068, 3164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3104, 3149);

                    return f_10386_3111_3148(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 3068, 3164);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10386_3111_3148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3111, 3148);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 2992, 3175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 2992, 3175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 3245, 3328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3281, 3313);

                    return f_10386_3288_3312(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 3245, 3328);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10386_3288_3312(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3288, 3312);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 3187, 3339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 3187, 3339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 3410, 3496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3446, 3481);

                    return f_10386_3453_3480(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 3410, 3496);

                    bool
                    f_10386_3453_3480(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3453, 3480);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 3351, 3507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 3351, 3507);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 3594, 3801);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3630, 3733) || true) && (f_10386_3634_3645())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10386, 3630, 3733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3687, 3714);

                        return f_10386_3694_3713(f_10386_3694_3703());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10386, 3630, 3733);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3753, 3786);

                    return f_10386_3760_3785(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 3594, 3801);

                    bool
                    f_10386_3634_3645()
                    {
                        var return_v = IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3634, 3645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    f_10386_3694_3703()
                    {
                        var return_v = TupleData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3694, 3703);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10386_3694_3713(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3694, 3713);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10386_3760_3785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3760, 3785);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 3519, 3812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 3519, 3812);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 3922, 4198);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 3958, 4114) || true) && (f_10386_3962_3973())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10386, 3958, 4114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4015, 4095);

                        return f_10386_4022_4094(f_10386_4074_4093(f_10386_4074_4083()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10386, 3958, 4114);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4134, 4183);

                    return f_10386_4141_4182(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 3922, 4198);

                    bool
                    f_10386_3962_3973()
                    {
                        var return_v = IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 3962, 3973);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    f_10386_4074_4083()
                    {
                        var return_v = TupleData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4074, 4083);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10386_4074_4093(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4074, 4093);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10386_4022_4094(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations)
                    {
                        var return_v = GetDeclaringSyntaxReferenceHelper<CSharpSyntaxNode>(locations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 4022, 4094);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10386_4141_4182(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4141, 4182);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 3824, 4209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 3824, 4209);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 4275, 4358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4311, 4343);

                    return f_10386_4318_4342(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 4275, 4358);

                    bool
                    f_10386_4318_4342(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4318, 4342);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 4221, 4369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 4221, 4369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 4437, 4522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4473, 4507);

                    return f_10386_4480_4506(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 4437, 4522);

                    bool
                    f_10386_4480_4506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4480, 4506);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 4381, 4533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 4381, 4533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 4611, 4704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4647, 4689);

                    return f_10386_4654_4688(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 4611, 4704);

                    bool
                    f_10386_4654_4688(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4654, 4688);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 4545, 4715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 4545, 4715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 4781, 4864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4817, 4849);

                    return f_10386_4824_4848(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 4781, 4864);

                    bool
                    f_10386_4824_4848(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4824, 4848);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 4727, 4875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 4727, 4875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 4951, 5042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 4987, 5027);

                    return f_10386_4994_5026(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 4951, 5042);

                    bool
                    f_10386_4994_5026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 4994, 5026);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 4887, 5053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 4887, 5053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5121, 5172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5124, 5172);
                    return f_10386_5124_5172(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5121, 5172);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5121, 5172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5121, 5172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5271, 5324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5277, 5322);

                    return f_10386_5284_5321(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5271, 5324);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10386_5284_5321(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5284, 5321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5185, 5335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5185, 5335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5416, 5469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5422, 5467);

                    return f_10386_5429_5466(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5416, 5469);

                    bool
                    f_10386_5429_5466(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ShouldAddWinRTMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5429, 5466);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5347, 5480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5347, 5480);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5562, 5616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5568, 5614);

                    return f_10386_5575_5613(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5562, 5616);

                    bool
                    f_10386_5575_5613(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsWindowsRuntimeImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5575, 5613);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5492, 5627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5492, 5627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5699, 5737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5705, 5735);

                    return f_10386_5712_5734(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5699, 5737);

                    Microsoft.CodeAnalysis.TypeLayout
                    f_10386_5712_5734(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Layout;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5712, 5734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5639, 5748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5639, 5748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5829, 5879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5835, 5877);

                    return f_10386_5842_5876(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5829, 5879);

                    System.Runtime.InteropServices.CharSet
                    f_10386_5842_5876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5842, 5876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5760, 5890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5760, 5890);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 5962, 6008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 5968, 6006);

                    return f_10386_5975_6005(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 5962, 6008);

                    bool
                    f_10386_5975_6005(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSerializable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5975, 6005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 5902, 6019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 5902, 6019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6090, 6135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6096, 6133);

                    return f_10386_6103_6132(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6090, 6135);

                    bool
                    f_10386_6103_6132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsRefLikeType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 6103, 6132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6031, 6146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6031, 6146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6214, 6256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6220, 6254);

                    return f_10386_6227_6253(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6214, 6256);

                    bool
                    f_10386_6227_6253(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 6227, 6253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6158, 6267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6158, 6267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6349, 6403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6355, 6401);

                    return f_10386_6362_6400(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6349, 6403);

                    bool
                    f_10386_6362_6400(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 6362, 6400);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6279, 6414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6279, 6414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6426, 6597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6538, 6586);

                return f_10386_6545_6585(_underlyingType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6426, 6597);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10386_6545_6585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetSecurityInformation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 6545, 6585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6426, 6597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6426, 6597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6609, 6770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6705, 6759);

                return f_10386_6712_6758(_underlyingType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6609, 6770);

                System.Collections.Immutable.ImmutableArray<string>
                f_10386_6712_6758(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAppliedConditionalSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 6712, 6758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6609, 6770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6609, 6770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6782, 6925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 6867, 6914);

                return f_10386_6874_6913(_underlyingType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6782, 6925);

                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10386_6874_6913(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 6874, 6913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6782, 6925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6782, 6925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10386, 6937, 7085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10386, 7021, 7074);

                return f_10386_7028_7073(_underlyingType, out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10386, 6937, 7085);

                bool
                f_10386_7028_7073(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidString(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 7028, 7073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10386, 6937, 7085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 6937, 7085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WrappedNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10386, 844, 7092);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10386, 844, 7092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10386, 844, 7092);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10386, 844, 7092);

        int
        f_10386_1223_1267(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10386, 1223, 1267);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        f_10386_1188_1197_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10386, 1080, 1326);
            return return_v;
        }


        bool
        f_10386_5124_5172(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.HasCodeAnalysisEmbeddedAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10386, 5124, 5172);
            return return_v;
        }

    }
}
