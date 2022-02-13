// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using System.Collections.Generic;
using System.Diagnostics;
using Cci = Microsoft.Cci;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedTypeParameter : EmbeddedTypesManager.CommonEmbeddedTypeParameter
    {
        public EmbeddedTypeParameter(EmbeddedMethod containingMethod, TypeParameterSymbolAdapter underlyingTypeParameter) : base(f_10949_824_840_C(containingMethod), underlyingTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10949, 690, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 891, 969);

                f_10949_891_968(f_10949_904_967(f_10949_904_954(underlyingTypeParameter)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10949, 690, 980);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 690, 980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 690, 980);
            }
        }

        protected override IEnumerable<Cci.TypeReferenceWithAttributes> GetConstraints(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 992, 1207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 1116, 1196);

                return f_10949_1123_1195(((Cci.IGenericParameter)UnderlyingTypeParameter), context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 992, 1207);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_10949_1123_1195(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetConstraints(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10949, 1123, 1195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 992, 1207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 992, 1207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool MustBeReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 1287, 1423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 1323, 1408);

                    return f_10949_1330_1407(f_10949_1330_1380(UnderlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 1287, 1423);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10949_1330_1380(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1330, 1380);
                        return return_v;
                    }


                    bool
                    f_10949_1330_1407(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1330, 1407);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 1219, 1434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 1219, 1434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool MustBeValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 1510, 1642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 1546, 1627);

                    return f_10949_1553_1626(f_10949_1553_1603(UnderlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 1510, 1642);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10949_1553_1603(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1553, 1603);
                        return return_v;
                    }


                    bool
                    f_10949_1553_1626(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1553, 1626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 1446, 1653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 1446, 1653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool MustHaveDefaultConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 1740, 1874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 1776, 1859);

                    return f_10949_1783_1858(f_10949_1783_1833(UnderlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 1740, 1874);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10949_1783_1833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1783, 1833);
                        return return_v;
                    }


                    bool
                    f_10949_1783_1858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1783, 1858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 1665, 1885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 1665, 1885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 1952, 2031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 1958, 2029);

                    return f_10949_1965_2028(f_10949_1965_2015(UnderlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 1952, 2031);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10949_1965_2015(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1965, 2015);
                        return return_v;
                    }


                    string
                    f_10949_1965_2028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 1965, 2028);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 1897, 2042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 1897, 2042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ushort Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10949, 2110, 2235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10949, 2146, 2220);

                    return (ushort)f_10949_2161_2219(f_10949_2161_2211(UnderlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10949, 2110, 2235);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10949_2161_2211(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 2161, 2211);
                        return return_v;
                    }


                    int
                    f_10949_2161_2219(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 2161, 2219);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10949, 2054, 2246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 2054, 2246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EmbeddedTypeParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10949, 579, 2253);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10949, 579, 2253);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10949, 579, 2253);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10949, 579, 2253);

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        f_10949_904_954(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
        this_param)
        {
            var return_v = this_param.AdaptedTypeParameterSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 904, 954);
            return return_v;
        }


        bool
        f_10949_904_967(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10949, 904, 967);
            return return_v;
        }


        int
        f_10949_891_968(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10949, 891, 968);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
        f_10949_824_840_C(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10949, 690, 980);
            return return_v;
        }

    }
}

