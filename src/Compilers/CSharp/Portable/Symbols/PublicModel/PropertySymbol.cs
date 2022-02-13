// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class PropertySymbol : Symbol, IPropertySymbol
    {
        private readonly Symbols.PropertySymbol _underlying;

        private ITypeSymbol _lazyType;

        public PropertySymbol(Symbols.PropertySymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10655, 571, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 507, 518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 549, 558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 652, 687);

                f_10655_652_686(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 701, 726);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10655, 571, 737);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 571, 737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 571, 737);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 798, 812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 801, 812);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 798, 812);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 798, 812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 798, 812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.IsIndexer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 880, 917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 886, 915);

                    return f_10655_893_914(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 880, 917);

                    bool
                    f_10655_893_914(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 893, 914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 825, 928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 825, 928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IPropertySymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 997, 1267);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1033, 1215) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10655, 1033, 1215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1096, 1196);

                        f_10655_1096_1195(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10655, 1033, 1215);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1235, 1252);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 997, 1267);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10655_1096_1195(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 1096, 1195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 940, 1278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 940, 1278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IPropertySymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 1357, 1412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1360, 1412);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 1357, 1412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 1357, 1412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 1357, 1412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IParameterSymbol> IPropertySymbol.Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 1509, 1566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1515, 1564);

                    return _underlying.Parameters.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 1509, 1566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 1425, 1577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 1425, 1577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IPropertySymbol.GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 1653, 1708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1659, 1706);

                    return f_10655_1666_1705(f_10655_1666_1687(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 1653, 1708);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10655_1666_1687(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 1666, 1687);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10655_1666_1705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 1666, 1705);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 1589, 1719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 1589, 1719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IPropertySymbol.SetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 1795, 1850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1801, 1848);

                    return f_10655_1808_1847(f_10655_1808_1829(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 1795, 1850);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10655_1808_1829(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 1808, 1829);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10655_1808_1847(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 1808, 1847);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 1731, 1861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 1731, 1861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IPropertySymbol IPropertySymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 1948, 2055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 1984, 2040);

                    return f_10655_1991_2039(f_10655_1991_2021(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 1948, 2055);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10655_1991_2021(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 1991, 2021);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IPropertySymbol?
                    f_10655_1991_2039(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 1991, 2039);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 1873, 2066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 1873, 2066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IPropertySymbol IPropertySymbol.OverriddenProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2153, 2217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2159, 2215);

                    return f_10655_2166_2214(f_10655_2166_2196(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2153, 2217);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10655_2166_2196(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 2166, 2196);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IPropertySymbol?
                    f_10655_2166_2214(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 2166, 2214);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2078, 2228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2078, 2228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IPropertySymbol> IPropertySymbol.ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2345, 2424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2351, 2422);

                    return _underlying.ExplicitInterfaceImplementations.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2345, 2424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2240, 2435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2240, 2435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2503, 2541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2509, 2539);

                    return f_10655_2516_2538(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2503, 2541);

                    bool
                    f_10655_2516_2538(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 2516, 2538);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2447, 2552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2447, 2552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.IsWriteOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2621, 2660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2627, 2658);

                    return f_10655_2634_2657(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2621, 2660);

                    bool
                    f_10655_2634_2657(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsWriteOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 2634, 2657);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2564, 2671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2564, 2671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.IsWithEvents
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2741, 2762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2747, 2760);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2741, 2762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2683, 2773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2683, 2773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IPropertySymbol.TypeCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 2876, 2939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 2882, 2937);

                    return _underlying.TypeWithAnnotations.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 2876, 2939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2785, 2950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2785, 2950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IPropertySymbol.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3052, 3098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3058, 3096);

                    return f_10655_3065_3095(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3052, 3098);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10655_3065_3095(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 3065, 3095);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 2962, 3109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 2962, 3109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.ReturnsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3155, 3182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3158, 3182);
                    return f_10655_3158_3182(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3155, 3182);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 3155, 3182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 3155, 3182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertySymbol.ReturnsByRefReadonly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3237, 3272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3240, 3272);
                    return f_10655_3240_3272(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3237, 3272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 3237, 3272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 3237, 3272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        RefKind IPropertySymbol.RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3317, 3339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3320, 3339);
                    return f_10655_3320_3339(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3317, 3339);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 3317, 3339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 3317, 3339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3387, 3504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3465, 3493);

                f_10655_3465_3492(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3387, 3504);

                int
                f_10655_3465_3492(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PropertySymbol
                symbol)
                {
                    this_param.VisitProperty((Microsoft.CodeAnalysis.IPropertySymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 3465, 3492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 3387, 3504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 3387, 3504);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10655, 3516, 3661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10655, 3615, 3650);

                return f_10655_3622_3649<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10655, 3516, 3661);

                TResult?
                f_10655_3622_3649<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PropertySymbol
                symbol)
                {
                    var return_v = this_param.VisitProperty((Microsoft.CodeAnalysis.IPropertySymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 3622, 3649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10655, 3516, 3661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 3516, 3661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10655, 388, 3690);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10655, 388, 3690);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10655, 388, 3690);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10655, 388, 3690);

        int
        f_10655_652_686(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10655, 652, 686);
            return 0;
        }


        bool
        f_10655_3158_3182(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.ReturnsByRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 3158, 3182);
            return return_v;
        }


        bool
        f_10655_3240_3272(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.ReturnsByRefReadonly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 3240, 3272);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10655_3320_3339(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10655, 3320, 3339);
            return return_v;
        }

    }
}
