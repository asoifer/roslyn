// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class LocalSymbol : Symbol, ILocalSymbol
    {
        private readonly Symbols.LocalSymbol _underlying;

        private ITypeSymbol _lazyType;

        public LocalSymbol(Symbols.LocalSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10644, 525, 685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 461, 472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 503, 512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 600, 635);

                f_10644_600_634(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 649, 674);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10644, 525, 685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 525, 685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 525, 685);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 746, 760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 749, 760);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 746, 760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 746, 760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 746, 760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol ILocalSymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 827, 1097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 863, 1045) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10644, 863, 1045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 926, 1026);

                        f_10644_926_1025(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10644, 863, 1045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1065, 1082);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 827, 1097);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10644_926_1025(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10644, 926, 1025);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 773, 1108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 773, 1108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation ILocalSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1184, 1239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1187, 1239);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1184, 1239);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1184, 1239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1184, 1239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbol.IsFunctionValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1310, 1374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1346, 1359);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1310, 1374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1252, 1385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1252, 1385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbol.IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1423, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1426, 1445);
                    return f_10644_1426_1445(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1423, 1445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1423, 1445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1423, 1445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbol.IsRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1482, 1502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1485, 1502);
                    return f_10644_1485_1502(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1482, 1502);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1482, 1502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1482, 1502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        RefKind ILocalSymbol.RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1544, 1566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1547, 1566);
                    return f_10644_1547_1566(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1544, 1566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1544, 1566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1544, 1566);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbol.HasConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1614, 1645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1617, 1645);
                    return f_10644_1617_1645(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1614, 1645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1614, 1645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1614, 1645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object ILocalSymbol.ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1692, 1720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1695, 1720);
                    return f_10644_1695_1720(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1692, 1720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1692, 1720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1692, 1720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbol.IsFixed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1759, 1781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1762, 1781);
                    return f_10644_1762_1781(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1759, 1781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1759, 1781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1759, 1781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1829, 1950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 1914, 1939);

                f_10644_1914_1938(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1829, 1950);

                int
                f_10644_1914_1938(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LocalSymbol
                symbol)
                {
                    this_param.VisitLocal((Microsoft.CodeAnalysis.ILocalSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10644, 1914, 1938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1829, 1950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1829, 1950);
            }
        }

        protected sealed override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10644, 1962, 2111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10644, 2068, 2100);

                return f_10644_2075_2099<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10644, 1962, 2111);

                TResult?
                f_10644_2075_2099<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LocalSymbol
                symbol)
                {
                    var return_v = this_param.VisitLocal((Microsoft.CodeAnalysis.ILocalSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10644, 2075, 2099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10644, 1962, 2111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 1962, 2111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10644, 351, 2140);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10644, 351, 2140);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10644, 351, 2140);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10644, 351, 2140);

        int
        f_10644_600_634(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10644, 600, 634);
            return 0;
        }


        bool
        f_10644_1426_1445(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.IsConst;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1426, 1445);
            return return_v;
        }


        bool
        f_10644_1485_1502(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.IsRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1485, 1502);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10644_1547_1566(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1547, 1566);
            return return_v;
        }


        bool
        f_10644_1617_1645(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.HasConstantValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1617, 1645);
            return return_v;
        }


        object
        f_10644_1695_1720(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.ConstantValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1695, 1720);
            return return_v;
        }


        bool
        f_10644_1762_1781(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        this_param)
        {
            var return_v = this_param.IsFixed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10644, 1762, 1781);
            return return_v;
        }

    }
}
