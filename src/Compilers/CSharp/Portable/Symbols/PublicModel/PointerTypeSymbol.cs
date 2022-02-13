// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class PointerTypeSymbol : TypeSymbol, IPointerTypeSymbol
    {
        private readonly Symbols.PointerTypeSymbol _underlying;

        private ITypeSymbol _lazyPointedAtType;

        public PointerTypeSymbol(Symbols.PointerTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10653_728_746_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10653, 593, 857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 520, 531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 562, 580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 772, 807);

                f_10653_772_806(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 821, 846);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10653, 593, 857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 593, 857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 593, 857);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 869, 1234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 999, 1073);

                f_10653_999_1072(nullableAnnotation != f_10653_1034_1071(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1087, 1147);

                f_10653_1087_1146(nullableAnnotation != f_10653_1122_1145(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1161, 1223);

                return f_10653_1168_1222(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 869, 1234);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10653_1034_1071(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10653, 1034, 1071);
                    return return_v;
                }


                int
                f_10653_999_1072(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 999, 1072);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10653_1122_1145(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10653, 1122, 1145);
                    return return_v;
                }


                int
                f_10653_1087_1146(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 1087, 1146);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                f_10653_1168_1222(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 1168, 1222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 869, 1234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 869, 1234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 1295, 1309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1298, 1309);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 1295, 1309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 1295, 1309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 1295, 1309);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 1400, 1414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1403, 1414);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 1400, 1414);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 1400, 1414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 1400, 1414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.TypeSymbol UnderlyingTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 1483, 1497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1486, 1497);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 1483, 1497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 1483, 1497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 1483, 1497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IPointerTypeSymbol.PointedAtType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 1579, 1885);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1615, 1824) || true) && (_lazyPointedAtType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10653, 1615, 1824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1687, 1805);

                        f_10653_1687_1804(ref _lazyPointedAtType, _underlying.PointedAtTypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10653, 1615, 1824);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 1844, 1870);

                    return _lazyPointedAtType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 1579, 1885);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10653_1687_1804(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 1687, 1804);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 1510, 1896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 1510, 1896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IPointerTypeSymbol.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 1998, 2070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 2004, 2068);

                    return _underlying.PointedAtTypeWithAnnotations.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 1998, 2070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 1908, 2081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 1908, 2081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 2128, 2248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 2206, 2237);

                f_10653_2206_2236(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 2128, 2248);

                int
                f_10653_2206_2236(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                symbol)
                {
                    this_param.VisitPointerType((Microsoft.CodeAnalysis.IPointerTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 2206, 2236);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 2128, 2248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 2128, 2248);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10653, 2260, 2408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10653, 2359, 2397);

                return f_10653_2366_2396<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10653, 2260, 2408);

                TResult?
                f_10653_2366_2396<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitPointerType((Microsoft.CodeAnalysis.IPointerTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 2366, 2396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10653, 2260, 2408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 2260, 2408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PointerTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10653, 388, 2437);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10653, 388, 2437);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10653, 388, 2437);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10653, 388, 2437);

        int
        f_10653_772_806(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10653, 772, 806);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10653_728_746_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10653, 593, 857);
            return return_v;
        }

    }
}
