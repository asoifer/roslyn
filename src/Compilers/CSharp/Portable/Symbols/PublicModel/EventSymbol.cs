// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class EventSymbol : Symbol, IEventSymbol
    {
        private readonly Symbols.EventSymbol _underlying;

        private ITypeSymbol? _lazyType;

        public EventSymbol(Symbols.EventSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10640, 540, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 475, 486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 518, 527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 615, 656);

                f_10640_615_655(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 670, 695);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10640, 540, 706);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 540, 706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 540, 706);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 767, 781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 770, 781);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 767, 781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 767, 781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 767, 781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbols.EventSymbol UnderlyingEventSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 843, 857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 846, 857);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 843, 857);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 843, 857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 843, 857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IEventSymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 924, 1194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 960, 1142) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10640, 960, 1142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1023, 1123);

                        f_10640_1023_1122(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10640, 960, 1142);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1162, 1179);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 924, 1194);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10640_1023_1122(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 1023, 1122);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 870, 1205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 870, 1205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IEventSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 1281, 1336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1284, 1336);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 1281, 1336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 1281, 1336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 1281, 1336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol? IEventSymbol.AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 1411, 1509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1447, 1494);

                    return f_10640_1454_1493(f_10640_1454_1475(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 1411, 1509);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10640_1454_1475(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10640, 1454, 1475);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10640_1454_1493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 1454, 1493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 1349, 1520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 1349, 1520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol? IEventSymbol.RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 1597, 1698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1633, 1683);

                    return f_10640_1640_1682(f_10640_1640_1664(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 1597, 1698);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10640_1640_1664(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10640, 1640, 1664);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10640_1640_1682(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 1640, 1682);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 1532, 1709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 1532, 1709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol? IEventSymbol.RaiseMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 1785, 1910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 1883, 1895);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 1785, 1910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 1721, 1921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 1721, 1921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEventSymbol IEventSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2002, 2109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2038, 2094);

                    return f_10640_2045_2093(f_10640_2045_2075(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2002, 2109);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10640_2045_2075(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10640, 2045, 2075);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IEventSymbol?
                    f_10640_2045_2093(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 2045, 2093);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 1933, 2120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 1933, 2120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEventSymbol? IEventSymbol.OverriddenEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2199, 2303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2235, 2288);

                    return f_10640_2242_2287(f_10640_2242_2269(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2199, 2303);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                    f_10640_2242_2269(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10640, 2242, 2269);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IEventSymbol?
                    f_10640_2242_2287(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 2242, 2287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 2132, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 2132, 2314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IEventSymbol> IEventSymbol.ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2425, 2547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2461, 2532);

                    return _underlying.ExplicitInterfaceImplementations.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2425, 2547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 2326, 2558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 2326, 2558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IEventSymbol.IsWindowsRuntimeEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2610, 2646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2613, 2646);
                    return f_10640_2613_2646(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2610, 2646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 2610, 2646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 2610, 2646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2694, 2808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2772, 2797);

                f_10640_2772_2796(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2694, 2808);

                int
                f_10640_2772_2796(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.EventSymbol
                symbol)
                {
                    this_param.VisitEvent((Microsoft.CodeAnalysis.IEventSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 2772, 2796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 2694, 2808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 2694, 2808);
            }
        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10640, 2820, 3000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10640, 2957, 2989);

                return f_10640_2964_2988<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10640, 2820, 3000);

                TResult?
                f_10640_2964_2988<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.EventSymbol
                symbol)
                {
                    var return_v = this_param.VisitEvent((Microsoft.CodeAnalysis.IEventSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 2964, 2988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10640, 2820, 3000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 2820, 3000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10640, 365, 3029);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10640, 365, 3029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10640, 365, 3029);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10640, 365, 3029);

        int
        f_10640_615_655(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10640, 615, 655);
            return 0;
        }


        bool
        f_10640_2613_2646(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.IsWindowsRuntimeEvent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10640, 2613, 2646);
            return return_v;
        }

    }
}
