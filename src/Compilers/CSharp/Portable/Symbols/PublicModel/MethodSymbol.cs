// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.Cci;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class MethodSymbol : Symbol, IMethodSymbol
    {
        private readonly Symbols.MethodSymbol _underlying;

        private ITypeSymbol _lazyReturnType;

        private ImmutableArray<ITypeSymbol> _lazyTypeArguments;

        private ITypeSymbol _lazyReceiverType;

        public MethodSymbol(Symbols.MethodSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10645, 766, 928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 583, 594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 625, 640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 736, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 843, 878);

                f_10645_843_877(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 892, 917);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10645, 766, 928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 766, 928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 766, 928);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 989, 1003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 992, 1003);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 989, 1003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 989, 1003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 989, 1003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbols.MethodSymbol UnderlyingMethodSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 1067, 1081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1070, 1081);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 1067, 1081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 1067, 1081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 1067, 1081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        MethodKind IMethodSymbol.MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 1154, 3315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1190, 3300);

                    switch (f_10645_1198_1220(_underlying))
                    {

                        case MethodKind.AnonymousFunction:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1322, 1358);

                            return MethodKind.AnonymousFunction;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.Constructor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1434, 1464);

                            return MethodKind.Constructor;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.Conversion:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1539, 1568);

                            return MethodKind.Conversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.DelegateInvoke:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1647, 1680);

                            return MethodKind.DelegateInvoke;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.Destructor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1755, 1784);

                            return MethodKind.Destructor;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.EventAdd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1857, 1884);

                            return MethodKind.EventAdd;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.EventRemove:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 1960, 1990);

                            return MethodKind.EventRemove;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.ExplicitInterfaceImplementation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2086, 2136);

                            return MethodKind.ExplicitInterfaceImplementation;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.UserDefinedOperator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2220, 2258);

                            return MethodKind.UserDefinedOperator;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.BuiltinOperator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2338, 2372);

                            return MethodKind.BuiltinOperator;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.Ordinary:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2445, 2472);

                            return MethodKind.Ordinary;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.PropertyGet:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2548, 2578);

                            return MethodKind.PropertyGet;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.PropertySet:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2654, 2684);

                            return MethodKind.PropertySet;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.ReducedExtension:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2765, 2800);

                            return MethodKind.ReducedExtension;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.StaticConstructor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2882, 2918);

                            return MethodKind.StaticConstructor;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.LocalFunction:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 2996, 3028);

                            return MethodKind.LocalFunction;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        case MethodKind.FunctionPointerSignature:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3117, 3160);

                            return MethodKind.FunctionPointerSignature;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 1190, 3300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3216, 3281);

                            throw f_10645_3222_3280(f_10645_3257_3279(_underlying));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 1190, 3300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 1154, 3315);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10645_1198_1220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 1198, 1220);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10645_3257_3279(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 3257, 3279);
                        return return_v;
                    }


                    System.Exception
                    f_10645_3222_3280(Microsoft.CodeAnalysis.MethodKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 3222, 3280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 1094, 3326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 1094, 3326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IMethodSymbol.ReturnType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 3399, 3693);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3435, 3635) || true) && (_lazyReturnType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 3435, 3635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3504, 3616);

                        f_10645_3504_3615(ref _lazyReturnType, _underlying.ReturnTypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 3435, 3635);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3655, 3678);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 3399, 3693);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10645_3504_3615(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 3504, 3615);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 3338, 3704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 3338, 3704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IMethodSymbol.ReturnNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 3811, 3928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 3847, 3913);

                    return _underlying.ReturnTypeWithAnnotations.ToPublicAnnotation();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 3811, 3928);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 3716, 3939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 3716, 3939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ITypeSymbol> IMethodSymbol.TypeArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 4031, 4365);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4067, 4304) || true) && (_lazyTypeArguments.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 4067, 4304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4143, 4285);

                        f_10645_4143_4284(ref _lazyTypeArguments, _underlying.TypeArgumentsWithAnnotations.GetPublicSymbols(), default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 4067, 4304);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4324, 4350);

                    return _lazyTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 4031, 4365);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_10645_4143_4284(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 4143, 4284);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 3951, 4376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 3951, 4376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CodeAnalysis.NullableAnnotation> IMethodSymbol.TypeArgumentNullableAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 4482, 4560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4498, 4560);
                    return _underlying.TypeArgumentsWithAnnotations.ToPublicAnnotations(); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 4482, 4560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 4482, 4560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 4482, 4560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ITypeParameterSymbol> IMethodSymbol.TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 4663, 4767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4699, 4752);

                    return _underlying.TypeParameters.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 4663, 4767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 4573, 4778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 4573, 4778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IParameterSymbol> IMethodSymbol.Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 4872, 4972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 4908, 4957);

                    return _underlying.Parameters.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 4872, 4972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 4790, 4983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 4790, 4983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5063, 5167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 5099, 5152);

                    return f_10645_5106_5151(f_10645_5106_5133(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5063, 5167);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_5106_5133(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 5106, 5133);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_5106_5151(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 5106, 5151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 4995, 5178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 4995, 5178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5244, 5336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 5280, 5321);

                    return f_10645_5287_5320(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5244, 5336);

                    bool
                    f_10645_5287_5320(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsEffectivelyReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 5287, 5320);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 5190, 5347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 5190, 5347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5413, 5494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 5449, 5479);

                    return f_10645_5456_5478(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5413, 5494);

                    bool
                    f_10645_5456_5478(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsInitOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 5456, 5478);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 5359, 5505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 5359, 5505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5588, 5695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 5624, 5680);

                    return f_10645_5631_5679(f_10645_5631_5661(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5588, 5695);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_5631_5661(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 5631, 5661);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_5631_5679(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 5631, 5679);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 5517, 5706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 5517, 5706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.OverriddenMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5787, 5892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 5823, 5877);

                    return f_10645_5830_5876(f_10645_5830_5858(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5787, 5892);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_5830_5858(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 5830, 5858);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_5830_5876(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 5830, 5876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 5718, 5903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 5718, 5903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IMethodSymbol.ReceiverType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 5978, 6303);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6014, 6243) || true) && (_lazyReceiverType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10645, 6014, 6243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6085, 6224);

                        f_10645_6085_6223(ref _lazyReceiverType, f_10645_6136_6216_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10645_6136_6160(_underlying), 10645, 6136, 6216).GetITypeSymbol((Microsoft.CodeAnalysis.NullableAnnotation)f_10645_6177_6215(_underlying))), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10645, 6014, 6243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6263, 6288);

                    return _lazyReceiverType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 5978, 6303);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10645_6136_6160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReceiverType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 6136, 6160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.NullableAnnotation?
                    f_10645_6177_6215(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReceiverNullableAnnotation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 6177, 6215);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10645_6136_6216_I(Microsoft.CodeAnalysis.ITypeSymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6136, 6216);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10645_6085_6223(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol?
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6085, 6223);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 5915, 6314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 5915, 6314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IMethodSymbol.ReceiverNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 6399, 6440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6402, 6440);
                    return f_10645_6402_6440(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 6399, 6440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 6399, 6440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 6399, 6440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 6517, 6617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6553, 6602);

                    return f_10645_6560_6601(f_10645_6560_6583(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 6517, 6617);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_6560_6583(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReducedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 6560, 6583);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_6560_6601(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6560, 6601);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 6453, 6628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 6453, 6628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IMethodSymbol.GetTypeInferredDuringReduction(ITypeParameterSymbol reducedFromTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 6640, 6968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 6768, 6957);

                return f_10645_6775_6956(f_10645_6775_6920(_underlying, f_10645_6836_6919(reducedFromTypeParameter, nameof(reducedFromTypeParameter))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 6640, 6968);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                f_10645_6836_6919(Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6836, 6919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10645_6775_6920(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                reducedFromTypeParameter)
                {
                    var return_v = this_param.GetTypeInferredDuringReduction(reducedFromTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6775, 6920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10645_6775_6956(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 6775, 6956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 6640, 6968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 6640, 6968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IMethodSymbol IMethodSymbol.ReduceExtensionMethod(ITypeSymbol receiverType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 6980, 7266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 7080, 7255);

                return f_10645_7087_7254(f_10645_7087_7218(_underlying, f_10645_7139_7198(receiverType, nameof(receiverType)), compilation: null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 6980, 7266);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10645_7139_7198(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 7139, 7198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10645_7087_7218(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                receiverType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.ReduceExtensionMethod(receiverType, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 7087, 7218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10645_7087_7254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 7087, 7254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 6980, 7266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 6980, 7266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<IMethodSymbol> IMethodSymbol.ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 7379, 7501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 7415, 7486);

                    return _underlying.ExplicitInterfaceImplementations.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 7379, 7501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 7278, 7512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 7278, 7512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol IMethodSymbol.AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 7587, 7692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 7623, 7677);

                    return f_10645_7630_7676(f_10645_7630_7658(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 7587, 7692);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10645_7630_7658(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 7630, 7658);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_10645_7630_7676(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 7630, 7676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 7524, 7703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 7524, 7703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 7774, 7860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 7810, 7845);

                    return f_10645_7817_7844(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 7774, 7860);

                    bool
                    f_10645_7817_7844(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 7817, 7844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 7715, 7871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 7715, 7871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 7934, 8012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 7970, 7997);

                    return f_10645_7977_7996(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 7934, 8012);

                    bool
                    f_10645_7977_7996(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAsync;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 7977, 7996);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 7883, 8023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 7883, 8023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 8101, 8194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 8137, 8179);

                    return f_10645_8144_8178(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 8101, 8194);

                    bool
                    f_10645_8144_8178(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HidesBaseMethodsByName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 8144, 8178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 8035, 8205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 8035, 8205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IMethodSymbol.ReturnTypeCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 8312, 8424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 8348, 8409);

                    return _underlying.ReturnTypeWithAnnotations.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 8312, 8424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 8217, 8435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 8217, 8435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IMethodSymbol.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 8535, 8624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 8571, 8609);

                    return f_10645_8578_8608(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 8535, 8624);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10645_8578_8608(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 8578, 8608);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 8447, 8635);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 8447, 8635);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<AttributeData> IMethodSymbol.GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 8647, 8840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 8741, 8829);

                return f_10645_8748_8785(_underlying).Cast<CSharpAttributeData, AttributeData>();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 8647, 8840);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10645_8748_8785(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 8748, 8785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 8647, 8840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 8647, 8840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        SignatureCallingConvention IMethodSymbol.CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 8911, 8967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 8914, 8967);
                    return f_10645_8914_8967(f_10645_8914_8943(_underlying)); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 8911, 8967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 8911, 8967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 8911, 8967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<INamedTypeSymbol> IMethodSymbol.UnmanagedCallingConventionTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 9059, 9145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 9062, 9145);
                    return _underlying.UnmanagedCallingConventionTypes.SelectAsArray(t => t.GetPublicSymbol()); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 9059, 9145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 9059, 9145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 9059, 9145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.Construct(params ITypeSymbol[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 9158, 9353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 9256, 9342);

                return f_10645_9263_9341(f_10645_9263_9323(_underlying, f_10645_9285_9322(typeArguments)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 9158, 9353);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10645_9285_9322(Microsoft.CodeAnalysis.ITypeSymbol[]
                typeArguments)
                {
                    var return_v = ConstructTypeArguments(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9285, 9322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10645_9263_9323(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9263, 9323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10645_9263_9341(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9263, 9341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 9158, 9353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 9158, 9353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IMethodSymbol IMethodSymbol.Construct(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<CodeAnalysis.NullableAnnotation> typeArgumentNullableAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 9365, 9681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 9551, 9670);

                return f_10645_9558_9669(f_10645_9558_9651(_underlying, f_10645_9580_9650(typeArguments, typeArgumentNullableAnnotations)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 9365, 9681);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10645_9580_9650(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                typeArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                typeArgumentNullableAnnotations)
                {
                    var return_v = ConstructTypeArguments(typeArguments, typeArgumentNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9580, 9650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10645_9558_9651(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9558, 9651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10645_9558_9669(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9558, 9669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 9365, 9681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 9365, 9681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IMethodSymbol IMethodSymbol.PartialImplementationPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 9771, 9885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 9807, 9870);

                    return f_10645_9814_9869(f_10645_9814_9851(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 9771, 9885);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_9814_9851(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.PartialImplementationPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 9814, 9851);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_9814_9869(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 9814, 9869);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 9693, 9896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 9693, 9896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol IMethodSymbol.PartialDefinitionPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 9982, 10092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10018, 10077);

                    return f_10645_10025_10076(f_10645_10025_10058(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 9982, 10092);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10645_10025_10058(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.PartialDefinitionPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10025, 10058);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10645_10025_10076(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 10025, 10076);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 9908, 10103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 9908, 10103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol IMethodSymbol.AssociatedAnonymousDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10198, 10261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10234, 10246);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10198, 10261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10115, 10272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10115, 10272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int IMethodSymbol.Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10308, 10328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10311, 10328);
                    return f_10645_10311_10328(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10308, 10328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10308, 10328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10308, 10328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10378, 10410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10381, 10410);
                    return f_10645_10381_10410(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10378, 10410);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10378, 10410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10378, 10410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10451, 10474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10454, 10474);
                    return f_10645_10454_10474(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10451, 10474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10451, 10474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10451, 10474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsCheckedBuiltin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10523, 10554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10526, 10554);
                    return f_10645_10526_10554(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10523, 10554);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10523, 10554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10523, 10554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10598, 10624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10601, 10624);
                    return f_10645_10601_10624(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10598, 10624);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10598, 10624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10598, 10624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.ReturnsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10669, 10696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10672, 10696);
                    return f_10645_10672_10696(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10669, 10696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10669, 10696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10669, 10696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.ReturnsByRefReadonly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10749, 10784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10752, 10784);
                    return f_10645_10752_10784(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10749, 10784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10749, 10784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10749, 10784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        RefKind IMethodSymbol.RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10827, 10849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10830, 10849);
                    return f_10645_10830_10849(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10827, 10849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10827, 10849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10827, 10849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IMethodSymbol.IsConditional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10895, 10923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10898, 10923);
                    return f_10645_10898_10923(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10895, 10923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10895, 10923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10895, 10923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        DllImportData IMethodSymbol.GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 10983, 11016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 10986, 11016);
                return f_10645_10986_11016(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 10983, 11016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 10983, 11016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 10983, 11016);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.DllImportData?
            f_10645_10986_11016(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.GetDllImportData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 10986, 11016);
                return return_v;
            }

        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 11064, 11179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 11142, 11168);

                f_10645_11142_11167(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 11064, 11179);

                int
                f_10645_11142_11167(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                symbol)
                {
                    this_param.VisitMethod((Microsoft.CodeAnalysis.IMethodSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 11142, 11167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 11064, 11179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 11064, 11179);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10645, 11191, 11334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10645, 11290, 11323);

                return f_10645_11297_11322<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10645, 11191, 11334);

                TResult?
                f_10645_11297_11322<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                symbol)
                {
                    var return_v = this_param.VisitMethod((Microsoft.CodeAnalysis.IMethodSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 11297, 11322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10645, 11191, 11334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 11191, 11334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10645, 470, 11363);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10645, 470, 11363);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10645, 470, 11363);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10645, 470, 11363);

        int
        f_10645_843_877(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 843, 877);
            return 0;
        }


        Microsoft.CodeAnalysis.NullableAnnotation
        f_10645_6402_6440(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReceiverNullableAnnotation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 6402, 6440);
            return return_v;
        }


        Microsoft.Cci.CallingConvention
        f_10645_8914_8943(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.CallingConvention;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 8914, 8943);
            return return_v;
        }


        System.Reflection.Metadata.SignatureCallingConvention
        f_10645_8914_8967(Microsoft.Cci.CallingConvention
        convention)
        {
            var return_v = convention.ToSignatureConvention();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10645, 8914, 8967);
            return return_v;
        }


        int
        f_10645_10311_10328(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10311, 10328);
            return return_v;
        }


        bool
        f_10645_10381_10410(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtensionMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10381, 10410);
            return return_v;
        }


        bool
        f_10645_10454_10474(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsVararg;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10454, 10474);
            return return_v;
        }


        bool
        f_10645_10526_10554(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsCheckedBuiltin;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10526, 10554);
            return return_v;
        }


        bool
        f_10645_10601_10624(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnsVoid;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10601, 10624);
            return return_v;
        }


        bool
        f_10645_10672_10696(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnsByRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10672, 10696);
            return return_v;
        }


        bool
        f_10645_10752_10784(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnsByRefReadonly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10752, 10784);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10645_10830_10849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10830, 10849);
            return return_v;
        }


        bool
        f_10645_10898_10923(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsConditional;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10645, 10898, 10923);
            return return_v;
        }

    }
}
