// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class FieldSymbol : Symbol, IFieldSymbol
    {
        private readonly Symbols.FieldSymbol _underlying;

        private ITypeSymbol _lazyType;

        public FieldSymbol(Symbols.FieldSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10641, 562, 722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 498, 509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 540, 549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 637, 672);

                f_10641_637_671(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 686, 711);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10641, 562, 722);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 562, 722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 562, 722);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 783, 797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 786, 797);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 783, 797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 783, 797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 783, 797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol IFieldSymbol.AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 872, 977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 908, 962);

                    return f_10641_915_961(f_10641_915_943(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 872, 977);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10641_915_943(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 915, 943);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_10641_915_961(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 915, 961);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 810, 988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 810, 988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IFieldSymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 1054, 1324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1090, 1272) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10641, 1090, 1272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1153, 1253);

                        f_10641_1153_1252(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10641, 1090, 1272);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1292, 1309);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 1054, 1324);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10641_1153_1252(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 1153, 1252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 1000, 1335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 1000, 1335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IFieldSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 1411, 1466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1414, 1466);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 1411, 1466);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 1411, 1466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 1411, 1466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IFieldSymbol.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 1563, 1626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1569, 1624);

                    return _underlying.TypeWithAnnotations.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 1563, 1626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 1479, 1637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 1479, 1637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IFieldSymbol IFieldSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 1718, 1825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1754, 1810);

                    return f_10641_1761_1809(f_10641_1761_1791(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 1718, 1825);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10641_1761_1791(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 1761, 1791);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IFieldSymbol?
                    f_10641_1761_1809(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 1761, 1809);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 1649, 1836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 1649, 1836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IFieldSymbol IFieldSymbol.CorrespondingTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 1922, 2034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 1958, 2019);

                    return f_10641_1965_2018(f_10641_1965_2000(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 1922, 2034);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10641_1965_2000(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.CorrespondingTupleField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 1965, 2000);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IFieldSymbol?
                    f_10641_1965_2018(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 1965, 2018);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 1848, 2045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 1848, 2045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbol.IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2083, 2105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2086, 2105);
                    return f_10641_2086_2105(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2083, 2105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2083, 2105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2083, 2105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbol.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2147, 2172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2150, 2172);
                    return f_10641_2150_2172(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2147, 2172);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2147, 2172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2147, 2172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbol.IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2214, 2239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2217, 2239);
                    return f_10641_2217_2239(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2214, 2239);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2214, 2239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2214, 2239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbol.IsFixedSizeBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2288, 2320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2291, 2320);
                    return f_10641_2291_2320(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2288, 2320);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2288, 2320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2288, 2320);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbol.HasConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2368, 2399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2371, 2399);
                    return f_10641_2371_2399(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2368, 2399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2368, 2399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2368, 2399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IFieldSymbol.ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2446, 2474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2449, 2474);
                    return f_10641_2449_2474(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2446, 2474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2446, 2474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2446, 2474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2522, 2636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2600, 2625);

                f_10641_2600_2624(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2522, 2636);

                int
                f_10641_2600_2624(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FieldSymbol
                symbol)
                {
                    this_param.VisitField((Microsoft.CodeAnalysis.IFieldSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 2600, 2624);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2522, 2636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2522, 2636);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10641, 2648, 2790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10641, 2747, 2779);

                return f_10641_2754_2778<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10641, 2648, 2790);

                TResult?
                f_10641_2754_2778<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FieldSymbol
                symbol)
                {
                    var return_v = this_param.VisitField((Microsoft.CodeAnalysis.IFieldSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 2754, 2778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10641, 2648, 2790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 2648, 2790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10641, 388, 2819);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10641, 388, 2819);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10641, 388, 2819);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10641, 388, 2819);

        int
        f_10641_637_671(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10641, 637, 671);
            return 0;
        }


        bool
        f_10641_2086_2105(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.IsConst;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2086, 2105);
            return return_v;
        }


        bool
        f_10641_2150_2172(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.IsReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2150, 2172);
            return return_v;
        }


        bool
        f_10641_2217_2239(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.IsVolatile;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2217, 2239);
            return return_v;
        }


        bool
        f_10641_2291_2320(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.IsFixedSizeBuffer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2291, 2320);
            return return_v;
        }


        bool
        f_10641_2371_2399(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.HasConstantValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2371, 2399);
            return return_v;
        }


        object
        f_10641_2449_2474(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.ConstantValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10641, 2449, 2474);
            return return_v;
        }

    }
}
