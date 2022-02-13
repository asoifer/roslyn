// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class ArrayTypeSymbol : TypeSymbol, IArrayTypeSymbol
    {
        private readonly Symbols.ArrayTypeSymbol _underlying;

        private ITypeSymbol? _lazyElementType;

        public ArrayTypeSymbol(Symbols.ArrayTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10635_721_739_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10635, 590, 856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 518, 529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 561, 577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 765, 806);

                f_10635_765_805(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 820, 845);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10635, 590, 856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 590, 856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 590, 856);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 868, 1231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 998, 1072);

                f_10635_998_1071(nullableAnnotation != f_10635_1033_1070(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1086, 1146);

                f_10635_1086_1145(nullableAnnotation != f_10635_1121_1144(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1160, 1220);

                return f_10635_1167_1219(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 868, 1231);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10635_1033_1070(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1033, 1070);
                    return return_v;
                }


                int
                f_10635_998_1071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 998, 1071);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10635_1121_1144(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1121, 1144);
                    return return_v;
                }


                int
                f_10635_1086_1145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 1086, 1145);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                f_10635_1167_1219(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 1167, 1219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 868, 1231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 868, 1231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1292, 1306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1295, 1306);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1292, 1306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1292, 1306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1292, 1306);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1375, 1389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1378, 1389);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1375, 1389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1375, 1389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1375, 1389);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1480, 1494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1483, 1494);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1480, 1494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1480, 1494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1480, 1494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int IArrayTypeSymbol.Rank
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1533, 1552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1536, 1552);
                    return f_10635_1536_1552(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1533, 1552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1533, 1552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1533, 1552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IArrayTypeSymbol.IsSZArray
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1597, 1621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1600, 1621);
                    return f_10635_1600_1621(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1597, 1621);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1597, 1621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1597, 1621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<int> IArrayTypeSymbol.LowerBounds
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1683, 1709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1686, 1709);
                    return f_10635_1686_1709(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1683, 1709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1683, 1709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1683, 1709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<int> IArrayTypeSymbol.Sizes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1765, 1785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1768, 1785);
                    return f_10635_1768_1785(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1765, 1785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1765, 1785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1765, 1785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IArrayTypeSymbol.ElementType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 1863, 2161);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1899, 2102) || true) && (_lazyElementType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10635, 1899, 2102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 1969, 2083);

                        f_10635_1969_2082(ref _lazyElementType, _underlying.ElementTypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10635, 1899, 2102);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 2122, 2146);

                    return _lazyElementType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 1863, 2161);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10635_1969_2082(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 1969, 2082);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 1798, 2172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 1798, 2172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IArrayTypeSymbol.ElementNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 2283, 2401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 2319, 2386);

                    return _underlying.ElementTypeWithAnnotations.ToPublicAnnotation();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 2283, 2401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 2184, 2412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 2184, 2412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IArrayTypeSymbol.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 2488, 2545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 2491, 2545);
                    return _underlying.ElementTypeWithAnnotations.CustomModifiers; DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 2488, 2545);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 2488, 2545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 2488, 2545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IArrayTypeSymbol.Equals(IArrayTypeSymbol? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 2558, 2737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 2636, 2726);

                return f_10635_2643_2725(this, other as ArrayTypeSymbol, CodeAnalysis.SymbolEqualityComparer.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 2558, 2737);

                bool
                f_10635_2643_2725(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol?
                otherType, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol?)otherType, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 2643, 2725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 2558, 2737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 2558, 2737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 2784, 2902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 2862, 2891);

                f_10635_2862_2890(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 2784, 2902);

                int
                f_10635_2862_2890(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                symbol)
                {
                    this_param.VisitArrayType((Microsoft.CodeAnalysis.IArrayTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 2862, 2890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 2784, 2902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 2784, 2902);
            }
        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10635, 2914, 3098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10635, 3051, 3087);

                return f_10635_3058_3086<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10635, 2914, 3098);

                TResult?
                f_10635_3058_3086<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                symbol)

                {
                    var return_v = this_param.VisitArrayType((Microsoft.CodeAnalysis.IArrayTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 3058, 3086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10635, 2914, 3098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 2914, 3098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10635, 392, 3127);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10635, 392, 3127);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10635, 392, 3127);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10635, 392, 3127);

        int
        f_10635_765_805(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10635, 765, 805);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10635_721_739_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10635, 590, 856);
            return return_v;
        }


        int
        f_10635_1536_1552(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.Rank;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1536, 1552);
            return return_v;
        }


        bool
        f_10635_1600_1621(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSZArray;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1600, 1621);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<int>
        f_10635_1686_1709(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.LowerBounds;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1686, 1709);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<int>
        f_10635_1768_1785(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.Sizes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10635, 1768, 1785);
            return return_v;
        }

    }
}
