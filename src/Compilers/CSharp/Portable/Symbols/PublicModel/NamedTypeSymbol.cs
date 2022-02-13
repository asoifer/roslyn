// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal abstract class NamedTypeSymbol : TypeSymbol, INamedTypeSymbol
    {
        private ImmutableArray<ITypeSymbol> _lazyTypeArguments;

        public NamedTypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation = CodeAnalysis.NullableAnnotation.None)
        : base(f_10647_686_704_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10647, 552, 727);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10647, 552, 727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 552, 727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 552, 727);
            }
        }

        internal abstract Symbols.NamedTypeSymbol UnderlyingNamedTypeSymbol { get; }

        int INamedTypeSymbol.Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 878, 968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 914, 953);

                    return f_10647_921_952(f_10647_921_946());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 878, 968);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_921_946()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 921, 946);
                        return return_v;
                    }


                    int
                    f_10647_921_952(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 921, 952);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 827, 979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 827, 979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IMethodSymbol> INamedTypeSymbol.InstanceConstructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 1083, 1207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 1119, 1192);

                    return f_10647_1126_1151().InstanceConstructors.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 1083, 1207);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_1126_1151()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 1126, 1151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 991, 1218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 991, 1218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IMethodSymbol> INamedTypeSymbol.StaticConstructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 1320, 1442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 1356, 1427);

                    return f_10647_1363_1388().StaticConstructors.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 1320, 1442);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_1363_1388()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 1363, 1388);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 1230, 1453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 1230, 1453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IMethodSymbol> INamedTypeSymbol.Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 1549, 1665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 1585, 1650);

                    return f_10647_1592_1617().Constructors.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 1549, 1665);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_1592_1617()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 1592, 1617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 1465, 1676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 1465, 1676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<string> INamedTypeSymbol.MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 1761, 1857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 1797, 1842);

                    return f_10647_1804_1841(f_10647_1804_1829());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 1761, 1857);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_1804_1829()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 1804, 1829);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_10647_1804_1841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MemberNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 1804, 1841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 1688, 1868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 1688, 1868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ITypeParameterSymbol> INamedTypeSymbol.TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 1973, 2091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 2009, 2076);

                    return f_10647_2016_2041().TypeParameters.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 1973, 2091);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_2016_2041()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 2016, 2041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 1880, 2102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 1880, 2102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ITypeSymbol> INamedTypeSymbol.TypeArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 2197, 2565);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 2233, 2504) || true) && (_lazyTypeArguments.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10647, 2233, 2504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 2309, 2485);

                        f_10647_2309_2484(ref _lazyTypeArguments, f_10647_2381_2406().TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.GetPublicSymbols(), default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10647, 2233, 2504);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 2524, 2550);

                    return _lazyTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 2197, 2565);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_2381_2406()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 2381, 2406);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_10647_2309_2484(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 2309, 2484);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 2114, 2576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 2114, 2576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CodeAnalysis.NullableAnnotation> INamedTypeSymbol.TypeArgumentNullableAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 2709, 2864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 2745, 2849);

                    return f_10647_2752_2777().TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.ToPublicAnnotations();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 2709, 2864);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_2752_2777()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 2752, 2777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 2588, 2875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 2588, 2875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> INamedTypeSymbol.GetTypeArgumentCustomModifiers(int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 2887, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 3003, 3110);

                return f_10647_3010_3084(f_10647_3010_3035())[ordinal].CustomModifiers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 2887, 3121);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_3010_3035()
                {
                    var return_v = UnderlyingNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3010, 3035);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10647_3010_3084(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3010, 3084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 2887, 3121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 2887, 3121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamedTypeSymbol INamedTypeSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 3210, 3331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 3246, 3316);

                    return f_10647_3253_3315(f_10647_3253_3297(f_10647_3253_3278()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 3210, 3331);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3253_3278()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3253, 3278);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3253_3297(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3253, 3297);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10647_3253_3315(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 3253, 3315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 3133, 3342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 3133, 3342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol INamedTypeSymbol.DelegateInvokeMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 3430, 3553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 3466, 3538);

                    return f_10647_3473_3537(f_10647_3473_3519(f_10647_3473_3498()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 3430, 3553);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3473_3498()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3473, 3498);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10647_3473_3519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DelegateInvokeMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3473, 3519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10647_3473_3537(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 3473, 3537);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 3354, 3564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 3354, 3564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol INamedTypeSymbol.EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 3653, 3774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 3689, 3759);

                    return f_10647_3696_3758(f_10647_3696_3740(f_10647_3696_3721()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 3653, 3774);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3696_3721()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3696, 3721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3696_3740(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3696, 3740);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10647_3696_3758(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 3696, 3758);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 3576, 3785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 3576, 3785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol INamedTypeSymbol.ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 3871, 3989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 3907, 3974);

                    return f_10647_3914_3973(f_10647_3914_3955(f_10647_3914_3939()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 3871, 3989);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3914_3939()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3914, 3939);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_3914_3955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 3914, 3955);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10647_3914_3973(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 3914, 3973);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 3797, 4000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 3797, 4000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol INamedTypeSymbol.Construct(params ITypeSymbol[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 4012, 4243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 4116, 4232);

                return f_10647_4123_4231(f_10647_4123_4213(f_10647_4123_4148(), f_10647_4159_4196(typeArguments), unbound: false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 4012, 4243);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4123_4148()
                {
                    var return_v = UnderlyingNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 4123, 4148);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10647_4159_4196(Microsoft.CodeAnalysis.ITypeSymbol[]
                typeArguments)
                {
                    var return_v = ConstructTypeArguments(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4159, 4196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4123_4213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4123, 4213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10647_4123_4231(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4123, 4231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 4012, 4243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 4012, 4243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamedTypeSymbol INamedTypeSymbol.Construct(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<CodeAnalysis.NullableAnnotation> typeArgumentNullableAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 4255, 4607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 4447, 4596);

                return f_10647_4454_4595(f_10647_4454_4577(f_10647_4454_4479(), f_10647_4490_4560(typeArguments, typeArgumentNullableAnnotations), unbound: false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 4255, 4607);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4454_4479()
                {
                    var return_v = UnderlyingNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 4454, 4479);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10647_4490_4560(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                typeArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                typeArgumentNullableAnnotations)
                {
                    var return_v = ConstructTypeArguments(typeArguments, typeArgumentNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4490, 4560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4454_4577(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4454, 4577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10647_4454_4595(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4454, 4595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 4255, 4607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 4255, 4607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamedTypeSymbol INamedTypeSymbol.ConstructUnboundGenericType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 4619, 4799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 4707, 4788);

                return f_10647_4714_4787(f_10647_4714_4769(f_10647_4714_4739()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 4619, 4799);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4714_4739()
                {
                    var return_v = UnderlyingNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 4714, 4739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10647_4714_4769(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4714, 4769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10647_4714_4787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 4714, 4787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 4619, 4799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 4619, 4799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ISymbol INamedTypeSymbol.AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 4877, 4940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 4913, 4925);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 4877, 4940);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 4811, 4951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 4811, 4951);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IFieldSymbol> INamedTypeSymbol.TupleElements
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 5256, 5373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 5292, 5358);

                    return f_10647_5299_5324().TupleElements.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 5256, 5373);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_5299_5324()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 5299, 5324);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 5172, 5384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 5172, 5384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol INamedTypeSymbol.TupleUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 5669, 6009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 5705, 5742);

                    var
                    type = f_10647_5716_5741()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 5760, 5811);

                    var
                    tupleUnderlyingType = f_10647_5786_5810(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 5829, 5994);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10647, 5836, 5904) || ((f_10647_5836_5904(type, tupleUnderlyingType, TypeCompareKind.ConsiderEverything) && DynAbs.Tracing.TraceSender.Conditional_F2(10647, 5928, 5932)) || DynAbs.Tracing.TraceSender.Conditional_F3(10647, 5956, 5993))) ? null : f_10647_5956_5993(tupleUnderlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 5669, 6009);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10647_5716_5741()
                    {
                        var return_v = UnderlyingNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 5716, 5741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10647_5786_5810(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 5786, 5810);
                        return return_v;
                    }


                    bool
                    f_10647_5836_5904(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 5836, 5904);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10647_5956_5993(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 5956, 5993);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 5591, 6020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 5591, 6020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6066, 6106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6069, 6106);
                    return f_10647_6069_6106(f_10647_6069_6094()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6066, 6106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6066, 6106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6066, 6106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsGenericType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6155, 6197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6158, 6197);
                    return f_10647_6158_6197(f_10647_6158_6183()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6155, 6197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6155, 6197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6155, 6197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsUnboundGenericType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6253, 6302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6256, 6302);
                    return f_10647_6256_6302(f_10647_6256_6281()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6253, 6302);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6253, 6302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6253, 6302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsScriptClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6351, 6393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6354, 6393);
                    return f_10647_6354_6393(f_10647_6354_6379()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6351, 6393);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6351, 6393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6351, 6393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsImplicitClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6444, 6488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6447, 6488);
                    return f_10647_6447_6488(f_10647_6447_6472()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6444, 6488);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6444, 6488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6444, 6488);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6552, 6609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6555, 6609);
                    return f_10647_6555_6609(f_10647_6555_6580()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6552, 6609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6552, 6609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6552, 6609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamedTypeSymbol.IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6659, 6702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6662, 6702);
                    return f_10647_6662_6702(f_10647_6662_6687()); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6659, 6702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6659, 6702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6659, 6702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol INamedTypeSymbol.NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6777, 6851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6780, 6851);
                    return f_10647_6780_6851(f_10647_6780_6833(f_10647_6780_6805())); DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6777, 6851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6777, 6851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6777, 6851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 6899, 7024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 6984, 7013);

                f_10647_6984_7012(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 6899, 7024);

                int
                f_10647_6984_7012(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamedTypeSymbol
                symbol)
                {
                    this_param.VisitNamedType((Microsoft.CodeAnalysis.INamedTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 6984, 7012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 6899, 7024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 6899, 7024);
            }
        }

        protected sealed override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10647, 7036, 7189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10647, 7142, 7178);

                return f_10647_7149_7177<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10647, 7036, 7189);

                TResult?
                f_10647_7149_7177<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitNamedType((Microsoft.CodeAnalysis.INamedTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 7149, 7177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10647, 7036, 7189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 7036, 7189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10647, 398, 7218);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10647, 398, 7218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10647, 398, 7218);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10647, 398, 7218);

        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10647_686_704_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10647, 552, 727);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6069_6094()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6069, 6094);
            return return_v;
        }


        bool
        f_10647_6069_6106(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsComImport;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6069, 6106);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6158_6183()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6158, 6183);
            return return_v;
        }


        bool
        f_10647_6158_6197(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6158, 6197);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6256_6281()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6256, 6281);
            return return_v;
        }


        bool
        f_10647_6256_6302(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsUnboundGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6256, 6302);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6354_6379()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6354, 6379);
            return return_v;
        }


        bool
        f_10647_6354_6393(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsScriptClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6354, 6393);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6447_6472()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6447, 6472);
            return return_v;
        }


        bool
        f_10647_6447_6488(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsImplicitClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6447, 6488);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6555_6580()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6555, 6580);
            return return_v;
        }


        bool
        f_10647_6555_6609(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.MightContainExtensionMethods;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6555, 6609);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6662_6687()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6662, 6687);
            return return_v;
        }


        bool
        f_10647_6662_6702(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSerializable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6662, 6702);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6780_6805()
        {
            var return_v = UnderlyingNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6780, 6805);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10647_6780_6833(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.NativeIntegerUnderlyingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10647, 6780, 6833);
            return return_v;
        }


        Microsoft.CodeAnalysis.INamedTypeSymbol?
        f_10647_6780_6851(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        symbol)
        {
            var return_v = symbol.GetPublicSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10647, 6780, 6851);
            return return_v;
        }

    }
}
